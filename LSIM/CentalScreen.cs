﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace LSIM
{
    public partial class CenterScreen : Form
    {
        public CenterScreen()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        public double PORO;
        public double KRW;
        public double KRO;
        public double L;
        public double B;
        public double H;
        public double Swcr;
        public double Sowc;
        public double Cw;
        public double Co;
        public double[] PERM;
        public double[] VISC;
        public double[] Z;
        public double[] Q;
        public double[] LIQ;
        public double[] OIL;


        public double PV;
        public double OIP;
        double VISCO;
        double VISCW;
        double DP;
        double ave = 0;

        private void SetModelOnClick(object sender, EventArgs e)
        {
            H = Convert.ToDouble(boxHeight.Text);
            B = Convert.ToDouble(boxWidth.Text);
            L = Convert.ToDouble(boxLength.Text);
            PORO = Convert.ToDouble(boxPoro.Text);
            Sowc = Convert.ToDouble(boxSOWC.Text);
            Swcr = Convert.ToDouble(boxSWCR.Text);
            KRW = Convert.ToDouble(boxKRW.Text);
            KRO = 1;
            Co = Convert.ToDouble(boxOCorey.Text);
            Cw = Convert.ToDouble(boxWCorey.Text);
            VISCO = Convert.ToDouble(boxOilVisc.Text) * 0.001;
            VISCW = Convert.ToDouble(boxWaterVisc.Text) * 0.001;
            DP = Convert.ToDouble(boxDepression.Text) * 101325;

            SetPerms(
                Convert.ToInt32(boxLines.Text),
                Convert.ToDouble(boxPermMean.Text),
                Convert.ToDouble(boxPermV2.Text));

            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart3.Series[1].Points.Clear();
            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();

            double sum = 0;


            for (int N = 0; N < PERM.Length; ++N)
            {
                sum += PERM[N];
                chart1.Series[0].Points.AddXY(PERM[N], (N + 0.5) * H / PERM.Length);
            }

            ave = sum / PERM.Length;

            double sumv = 0;
            double sigma = 0;

            for (int N = 0; N < PERM.Length; ++N)
            {
                sumv += (PERM[N] - ave) * (PERM[N] - ave);
            }
            sigma = sumv / PERM.Length;

            PV = L * B * H * PORO;
            OIP = PV * (1 - Swcr);

            listOutput.Items.Clear();
            listOutput.Items.Add(String.Format("Pore volume, m3 \t\t{0}", PV));
            listOutput.Items.Add(String.Format("Oil in place, m3 \t\t{0}", OIP));
            listOutput.Items.Add(String.Format("Water in place, m3 \t\t{0}", PV * Swcr));
            listOutput.Items.Add(String.Format("Mobile oil in place, m3 \t{0}", OIP - PV * Sowc));
            listOutput.Items.Add(String.Format("Recovery factor \t\t{0}", (OIP - PV * Sowc) / OIP));
            listOutput.Items.Add(String.Format("Maximum permability, mD \t\t{0,2:N2}", PERM[0]));
            listOutput.Items.Add(String.Format("Minimum permability, mD \t\t{0,2:N2}", PERM[PERM.Length - 1]));
            listOutput.Items.Add(String.Format("Average permability, mD \t\t{0,2:N2}", ave));
            listOutput.Items.Add(String.Format("Square variation of permability \t{0,2:N3}", sigma / ave / ave));

            chart5.Series[0].Points.Clear();
            chart5.Series[1].Points.Clear();

            double dSw = (1 - Sowc - Swcr) / 10; // Шаг по насыщенности
            for (int J = 0; J <= 10; ++J)
            {
                double Sw = Swcr + dSw * J;
                double Swd = GetSwd(Sw);
                chart5.Series[0].Points.AddXY(Sw, GetKrw(Swd));
                chart5.Series[1].Points.AddXY(Sw, GetKro(Swd));
            }

            GenerateLookUpTables();

            /// Расчет показателей разработки одного слоя

            double T = 30; // days

            LIQ = new double[PERM.Length];
            OIL = new double[PERM.Length];

            Q = new double[PERM.Length];

            for (int IT = 0; IT < 120; ++IT)
            {
                for (int IW = 0; IW < PERM.Length; ++IW)
                {

                    // Prev 
                    double mOIP = Q[IW] / (OIP / PERM.Length);
                    double mLa = GetL(mOIP);
                    double mW = GetW(mOIP);
                    double mLiq = 86400 * B * (H / PERM.Length) * 1e-15 * PERM[IW] * DP / (L * 0.001 * mLa);

                    LIQ[IW] = mLiq;
                    OIL[IW] = mLiq * (1 - mW);

                    // Next

                    double CLIQ = mLiq * T;
                    double aW = mW;
                    double ppCLIQ = CLIQ;
                    do
                    {
                        double nOIP = (Q[IW] + CLIQ * (1 - aW)) / (OIP / PERM.Length);
                        double nLa = GetL(nOIP);
                        double nLiq = 86400 * B * (H / PERM.Length) * 1e-15 * PERM[IW] * DP / (L * 0.001 * nLa);
                        double aLiq = (mLiq + nLiq) / 2;
                        ppCLIQ = CLIQ;
                        CLIQ = aLiq * T;
                    } while (Math.Abs(CLIQ - ppCLIQ) > 0.0001);

                    Q[IW] = Q[IW] + CLIQ * (1 - aW);

                    if (Q[IW] > (OIP / PERM.Length)) Q[IW] = (OIP / PERM.Length);
                }
            
                System.Diagnostics.Debug.WriteLine($"LIQ = {LIQ.Sum()}  OIL = {OIL.Sum()}");
            }
        }

        public double GetSwd(double Sw)
        {
            return (Sw - Swcr) / (1 - Sowc - Swcr);
        }

        public double GetKro(double Swd)
        {
            return KRO * Math.Pow((1 - Swd), Co);
        }

        public double GetKrw(double Swd)
        {
            return KRW * Math.Pow(Swd, Cw);
        }

        public double Getfw(double Swd) // Функция fw в точке Swd
        {
            double A = (KRO * VISCW) / (KRW * VISCO);
            return Math.Pow(Swd, Cw) / (Math.Pow(Swd, Cw) + A * Math.Pow((1 - Swd), Co));
        }

        public double GetdfwdSw(double Swd) // Производная fw` в точке Swd
        {
            double A = (KRO * VISCW) / (KRW * VISCO);
            return (1 / (1 - Sowc - Swcr)) * A * (Cw * Math.Pow(Swd, (Cw - 1)) * Math.Pow((1 - Swd), Co) + Co * Math.Pow(Swd, Cw) * Math.Pow((1 - Swd), (Co - 1))) / (Math.Pow((Math.Pow(Swd, Cw) + A * Math.Pow((1 - Swd), Co)), 2));
        }

        public double GetSwf(double Sw)
        {
            double L = Swcr;
            double R = 1 - Sowc;
            double C = 0;

            double Swd; // Нормированная насыщенность
            double dfwdSw;
            double Y = 1;
            double eps = 1e-5;

            while (Math.Abs(Y) > eps)
            {
                C = (L + R) * 0.5;

                Swd = GetSwd(C);
                dfwdSw = GetdfwdSw(Swd);

                // Проводим линию касательной к функции fw, если в точке Swi она не пересекает ноль, значит решение пока не найдено

                Y = Getfw(Swd) + dfwdSw * (Sw - C);

                if (Y < -eps)
                {
                    L = C;
                }

                if (Y > +eps)
                {
                    R = C;
                }
            }

            return C;
        } // Получить насыщенность на фронте вытеснения

        public double GetLaAverage(double Sw) // Определение средней вязкости в интервале насыщенности от Sw до (1 - Sor)
        {
            // Решение интеграла методом трапеции

            int N = 49;
            double dSw = (1 - Sowc - Swcr) / N;
            double Swd;
            double Kro, Krw;
            double La1, La2;
            double dfwdSw1, dfwdSw2;
            double dfwdSwi;
            double LaSum;

            double h;

            Swd = GetSwd(Sw);
            Kro = GetKro(Swd);
            Krw = GetKrw(Swd);

            La1 = 1 / (Kro / VISCO + Krw / VISCW);

            if (dSw == 0) return La1;

            dfwdSw1 = GetdfwdSw(Swd);

            dfwdSwi = dfwdSw1;

            LaSum = 0;

            for (int i = 0; i < (N); ++i)
            {
                Sw = Sw + dSw;

                if (Sw > (1 - Sowc)) Sw = 1 - Sowc;

                Swd = GetSwd(Sw);
                Kro = GetKro(Swd);
                Krw = GetKrw(Swd);
                La2 = 1 / (Kro / VISCO + Krw / VISCW);
                dfwdSw2 = GetdfwdSw(Swd);

                h = dfwdSw1 - dfwdSw2;

                LaSum = LaSum + 0.5 * (La1 + La2) * h;

                La1 = La2;
                dfwdSw1 = dfwdSw2;
            }

            return LaSum / dfwdSwi;
        }


        List<Tuple<double, double>> W = new List<Tuple<double, double>>();
        List<Tuple<double, double>> LA = new List<Tuple<double, double>>();

        double GetW(double Q)
        {
            if (Q >= 1) return W[W.Count - 1].Item2;

            for (int iw = 0; iw < W.Count; ++iw)
            {
                if (W[iw].Item1 < Q && W[iw + 1].Item1 >= Q)
                {
                    double prop = (Q - W[iw].Item1) / (W[iw + 1].Item1 - W[iw].Item1);
                    return W[iw].Item2 + prop * (W[iw + 1].Item2 - W[iw].Item2);
                }
            }

            return W[0].Item2;
        }

        double GetL(double Q)
        {
            if (Q >= 1) return LA[LA.Count - 1].Item2;

            for (int iw = 0; iw < LA.Count; ++iw)
            {
                if (LA[iw].Item1 < Q && LA[iw + 1].Item1 >= Q)
                {
                    double prop = (Q - LA[iw].Item1) / (LA[iw + 1].Item1 - LA[iw].Item1);
                    return LA[iw].Item2 + prop * (LA[iw + 1].Item2 - LA[iw].Item2);
                }
            }

            return LA[0].Item2;
        }
        public void GenerateLookUpTables()
        {
            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();

            double Swf = GetSwf(Swcr); // Насыщение на фронте вытеснения

            // Нулевой момент времени

            double Qibt = 1 / GetdfwdSw(GetSwd(Swf));
            double dQibt = Qibt / 10;
            double Labt = GetLaAverage(Swf);
            
            double Qo = 160.285 * (1 - Sowc - Swcr);

            double time = 0;
            double Qi_t_prev = 0;
            double qt_t_prev = 0;
            double qw = 0;
            double qo = 0;
            double WCT = 0;

            for (int J = 0; J <= 10; ++J) // Десять расчетных шагов до начала обводнения
            {
                double Qi_t = dQibt * J;
                double La_t = VISCO + (Labt - VISCO) * J / 10;
                double qt_t = GetLiquidRate(La_t);

                if (J > 0)
                {
                    time = time + 2 * (Qi_t - Qi_t_prev) * 160285 / (qt_t + qt_t_prev);
                }

                qo = qt_t;

                if (J == 10) // Прорыв в добывающую скважину
                {
                    var fw = Getfw(GetSwd(Swf));
                    qw = qt_t * fw;
                    qo = qt_t - qw;
                    WCT = fw;

                    chart4.Series[1].Points.AddXY(Qi_t * 160.285 / Qo, 0);
                }

                chart4.Series[0].Points.AddXY(Qi_t * 160.285 / Qo, 1000 * La_t);
                chart4.Series[1].Points.AddXY(Qi_t * 160.285 / Qo, WCT);


                LA.Add(new Tuple<double, double>(Qi_t * 160.285 / Qo, 1000 * La_t));
                W.Add(new Tuple<double, double>( Qi_t * 160.285 / Qo, WCT ));

                //text.WriteLine($"{time:F1}\t{qo:N2}\t{qw:N2}\t{qt_t:N2}\t{WCT:N3}\t{Qi_t:N3}\t{Qi_t:N3}\t{Qi_t * 160.285:N3}\t{La_t:N4}");

                Qi_t_prev = Qi_t;
                qt_t_prev = qt_t;
            }

            int N = 101;
            double dSw = (1 - Sowc - Swf) / (N - 1);
            double Sw = Swf;

            for (int i = 0; i < N - 2; ++i)
            {
                double Qi = 1 / GetdfwdSw(GetSwd(Sw));

                var La = GetLaAverage(Sw);
                var qt_t = GetLiquidRate(La);

                var fw = Getfw(GetSwd(Sw));

                var Swav = Sw + (1 - fw) / GetdfwdSw(  GetSwd(Sw));

                qw = qt_t * fw;
                qo = qt_t - qw;

                WCT = fw;

                if (WCT > 0.999) break;


               // if (i > 0)
               // {
                    time = time + 2 * (Qi - Qi_t_prev) * 160285 / (qt_t + qt_t_prev);

                    chart4.Series[0].Points.AddXY(160.285 * (Swav - Swcr) / Qo, 1000 * La);
                    chart4.Series[1].Points.AddXY(160.285 * (Swav - Swcr) / Qo, WCT);

               
                LA.Add(new Tuple<double, double>(160.285 * (Swav - Swcr) / Qo, 1000 * La));
                W.Add(new Tuple<double, double>(160.285 * (Swav - Swcr) / Qo, WCT));

                //text.WriteLine($"{time:F1}\t{qo:N2}\t{qw:N2}\t{qt_t:N2}\t{WCT:N3}\t{Qi:N3}\t{Qi:N3}\t{160.285 * (Swav - BL.Swi):N3}\t{La:N4}");
                //}

                Qi_t_prev = Qi;
                qt_t_prev = qt_t;

                Sw = Sw + dSw;
            }

            chart4.Series[0].Points.AddXY(1, 1000 * VISCW / KRW);
            chart4.Series[1].Points.AddXY(1, 1);

            LA.Add(new Tuple<double, double>(1, 1000 * VISCW/ KRW));
            W.Add(new Tuple<double, double>(1, 1));

        }

        public double GetLiquidRate(double La)
        {
            return (1.127 * 0.200 * 20 * 300 * 500) / (La * 1000);
        }

        void SetPerms(int lines, double mean, double V2)
        {
            PERM = new double[lines];
            VISC = new double[lines];
            Z = new double[lines];
            Q = new double[lines];

            chart3.Series[0].Points.Clear();

            double B = 1 / V2;
            double C = 1 / (mean * V2);
            double A = Math.Pow(C, B) / Statistic.gamma(B);
            double Delta = 1 / ((double)lines);
            double Y = 0;
            double Middle = 0;
            double Left = 0;
            double Right = 1e20;
            double K = 0;
            double Epsilon = 1e-7; // accuracity

            for (int N = 0; N < lines; ++N)
            {
                Middle = (2 * N + 1) * Delta / 2; // middle point of height

                // iteration for find permability of middle point

                Left = 0;
                Right = 1e20;
                K = (Left + Right) * 0.5;
                Y = Statistic.incompletegamma(B, K * C);

                while (Math.Abs(Y - Middle) > Epsilon)
                {
                    if (Y < Middle) Left = K;
                    if (Y > Middle) Right = K;
                    K = (Left + Right) * 0.5;
                    Y = Statistic.incompletegamma(B, K * C);
                }
                PERM[lines - N - 1] = K;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double T = Convert.ToDouble(numericUpDown1.Value);

            if (comboBox1.SelectedIndex == 1) T = T * 86400;
            if (comboBox1.SelectedIndex == 2) T = T * 86400 * 365;


            //for (int N = 0; N < PERM.Length; ++N)
            //{
            //    double TMAX = PORO * Swcr * L * L * 0.5 * (VISCW + VISCO) / (PERM[N] * 1e-15 * DP);
            //    double Z = L;

            //    if (TMAX > T)
            //    {
            //        Z = (VISCO * L - Math.Sqrt(VISCO * VISCO * L * L - (2 * (VISCO - VISCW) * T * PERM[N] * 1e-15 * DP / (PORO * Swcr)))) / (VISCO - VISCW);
            //    }

            //    chart2.Series[0].Points.AddXY(Z, (N + 0.5) * H / PERM.Length);
            //}



            // Calculate viscosity from position Z

            for (int it = 0; it < 10; ++it)
            {
                for (int iw = 0; iw < Z.Length; ++iw)
                {
                    if (Z[iw] > L) VISC[iw] = VISCW;
                    else
                        VISC[iw] = (VISCO * (L - Z[iw]) + VISCW * Z[iw]) / L;

                    Q[iw] = PERM[iw] * 1e-15 * DP * B * H / ((VISC[iw] + VISCO) * 0.5 * L * Z.Length);
                }

                for (int iw = 0; iw < Z.Length; ++iw)
                {
                    Z[iw] = Q[iw] * T * Z.Length / (B * H * Swcr * PORO);
                }
            }

            // End iteration

            chart2.Series[0].Points.Clear();
            chart2.Series[0].Points.AddXY(0, 0);
            chart2.ChartAreas[0].AxisX.Maximum = 1.01 * L;
            chart2.ChartAreas[0].AxisX.Minimum = 0;

            double COP = 0.00;
            double LPR = 0.00;
            double WPR = 0.00;
            double Krw = 0;
            double Kro = 0;

            for (int iw = 0; iw < Z.Length; ++iw)
            {
                if (Z[iw] > L) Z[iw] = L;

                COP += Z[iw] * B * H * (1 - Swcr) * PORO / Z.Length;
                LPR += PERM[iw] * 1e-15 * DP * B * H / (VISC[iw] * L * Z.Length);

                if (Z[iw] == L) WPR += PERM[iw] * 1e-15 * DP * B * H / (VISC[iw] * L * Z.Length);

                chart2.Series[0].Points.AddXY(Z[iw], (iw + 0.5) * H / PERM.Length);
            }

            chart3.Series[0].Points.AddXY(COP / OIP, LPR * 86400);
            chart3.Series[1].Points.AddXY(COP / OIP, (LPR - WPR) * 86400);

            Krw = KRW * WPR * VISCW * L / (B * H * DP * ave * 1e-15);
            Kro = (LPR - WPR) * VISCO * L / (B * H * DP * ave * 1e-15);

            chart4.Series[0].Points.AddXY(Swcr + COP / OIP * (Swcr + Sowc), Krw);
            chart4.Series[1].Points.AddXY(Swcr + COP / OIP * (Swcr + Sowc), Kro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationClass XL = new ApplicationClass();
            XL.Visible = false;
            XL.Interactive = false;
            XL.ScreenUpdating = false;

            Workbook wb = XL.Workbooks.Add();
            Worksheet ws = (Worksheet)wb.Sheets[1];

            ((Range)ws.Cells[2, 1]).Value2 = "Permability, mD";
            ((Range)ws.Cells[2, 2]).Value2 = "Height, m";


            for (int iw = 0; iw < chart1.Series[0].Points.Count; ++iw)
            {
                ((Range)ws.Cells[iw + 4, 1]).Value2 = chart1.Series[0].Points[iw].XValue;
                ((Range)ws.Cells[iw + 4, 2]).Value2 = chart1.Series[0].Points[iw].YValues[0];
            }

            ((Range)ws.Cells[2, 4]).Value2 = "Position, m";
            ((Range)ws.Cells[2, 5]).Value2 = "Height, m";

            for (int iw = 1; iw < chart2.Series[0].Points.Count; ++iw)
            {
                ((Range)ws.Cells[iw + 3, 4]).Value2 = chart2.Series[0].Points[iw].XValue;
                ((Range)ws.Cells[iw + 3, 5]).Value2 = chart2.Series[0].Points[iw].YValues[0];
            }

            ((Range)ws.Cells[2, 7]).Value2 = "% OIP";
            ((Range)ws.Cells[2, 8]).Value2 = "Liquid rate, m3/day";
            ((Range)ws.Cells[2, 9]).Value2 = "Oil rate, m3/day";

            for (int iw = 0; iw < chart3.Series[0].Points.Count; ++iw)
            {
                ((Range)ws.Cells[iw + 4, 7]).Value2 = chart3.Series[0].Points[iw].XValue;
                ((Range)ws.Cells[iw + 4, 8]).Value2 = chart3.Series[0].Points[iw].YValues[0];
                ((Range)ws.Cells[iw + 4, 9]).Value2 = chart3.Series[1].Points[iw].YValues[0];
            }

            ((Range)ws.Cells[2, 11]).Value2 = "Sw";
            ((Range)ws.Cells[2, 12]).Value2 = "Krw";
            ((Range)ws.Cells[2, 13]).Value2 = "Kro";

            for (int iw = 0; iw < chart3.Series[0].Points.Count; ++iw)
            {
                ((Range)ws.Cells[iw + 4, 11]).Value2 = chart4.Series[0].Points[iw].XValue;
                ((Range)ws.Cells[iw + 4, 12]).Value2 = chart4.Series[0].Points[iw].YValues[0];
                ((Range)ws.Cells[iw + 4, 13]).Value2 = chart4.Series[1].Points[iw].YValues[0];
            }

            XL.Visible = true;
            XL.Interactive = true;
            XL.ScreenUpdating = true;
        }


    }

    class Statistic
    {
        public static double gamma(double x)
        {
            double result = 0;
            double p = 0;
            double pp = 0;
            double q = 0;
            double qq = 0;
            double z = 0;
            int i = 0;
            double sgngam = 0;

            sgngam = 1;
            q = Math.Abs(x);
            if ((double)(q) > (double)(33.0))
            {
                if ((double)(x) < (double)(0.0))
                {
                    p = (int)Math.Floor(q);
                    i = (int)Math.Round(p);
                    if (i % 2 == 0)
                    {
                        sgngam = -1;
                    }
                    z = q - p;
                    if ((double)(z) > (double)(0.5))
                    {
                        p = p + 1;
                        z = q - p;
                    }
                    z = q * Math.Sin(Math.PI * z);
                    z = Math.Abs(z);
                    z = Math.PI / (z * gammastirf(q));
                }
                else
                {
                    z = gammastirf(x);
                }
                result = sgngam * z;
                return result;
            }
            z = 1;
            while ((double)(x) >= (double)(3))
            {
                x = x - 1;
                z = z * x;
            }
            while ((double)(x) < (double)(0))
            {
                if ((double)(x) > (double)(-0.000000001))
                {
                    result = z / ((1 + 0.5772156649015329 * x) * x);
                    return result;
                }
                z = z / x;
                x = x + 1;
            }
            while ((double)(x) < (double)(2))
            {
                if ((double)(x) < (double)(0.000000001))
                {
                    result = z / ((1 + 0.5772156649015329 * x) * x);
                    return result;
                }
                z = z / x;
                x = x + 1.0;
            }
            if ((double)(x) == (double)(2))
            {
                result = z;
                return result;
            }
            x = x - 2.0;
            pp = 1.60119522476751861407E-4;
            pp = 1.19135147006586384913E-3 + x * pp;
            pp = 1.04213797561761569935E-2 + x * pp;
            pp = 4.76367800457137231464E-2 + x * pp;
            pp = 2.07448227648435975150E-1 + x * pp;
            pp = 4.94214826801497100753E-1 + x * pp;
            pp = 9.99999999999999996796E-1 + x * pp;
            qq = -2.31581873324120129819E-5;
            qq = 5.39605580493303397842E-4 + x * qq;
            qq = -4.45641913851797240494E-3 + x * qq;
            qq = 1.18139785222060435552E-2 + x * qq;
            qq = 3.58236398605498653373E-2 + x * qq;
            qq = -2.34591795718243348568E-1 + x * qq;
            qq = 7.14304917030273074085E-2 + x * qq;
            qq = 1.00000000000000000320 + x * qq;
            result = z * pp / qq;
            return result;
        }
        private static double gammastirf(double x)
        {
            double result = 0;
            double y = 0;
            double w = 0;
            double v = 0;
            double stir = 0;

            w = 1 / x;
            stir = 7.87311395793093628397E-4;
            stir = -2.29549961613378126380E-4 + w * stir;
            stir = -2.68132617805781232825E-3 + w * stir;
            stir = 3.47222221605458667310E-3 + w * stir;
            stir = 8.33333333333482257126E-2 + w * stir;
            w = 1 + w * stir;
            y = Math.Exp(x);
            if ((double)(x) > (double)(143.01608))
            {
                v = Math.Pow(x, 0.5 * x - 0.25);
                y = v * (v / y);
            }
            else
            {
                y = Math.Pow(x, x - 0.5) / y;
            }
            result = 2.50662827463100050242 * y * w;
            return result;
        }
        public static double lngamma(double x, ref double sgngam)
        {
            double result = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double p = 0;
            double q = 0;
            double u = 0;
            double w = 0;
            double z = 0;
            int i = 0;
            double logpi = 0;
            double ls2pi = 0;
            double tmp = 0;

            sgngam = 1;
            logpi = 1.14472988584940017414;
            ls2pi = 0.91893853320467274178;
            if ((double)(x) < (double)(-34.0))
            {
                q = -x;
                w = lngamma(q, ref tmp);
                p = (int)Math.Floor(q);
                i = (int)Math.Round(p);
                if (i % 2 == 0)
                {
                    sgngam = -1;
                }
                else
                {
                    sgngam = 1;
                }
                z = q - p;
                if ((double)(z) > (double)(0.5))
                {
                    p = p + 1;
                    z = p - q;
                }
                z = q * Math.Sin(Math.PI * z);
                result = logpi - Math.Log(z) - w;
                return result;
            }
            if ((double)(x) < (double)(13))
            {
                z = 1;
                p = 0;
                u = x;
                while ((double)(u) >= (double)(3))
                {
                    p = p - 1;
                    u = x + p;
                    z = z * u;
                }
                while ((double)(u) < (double)(2))
                {
                    z = z / u;
                    p = p + 1;
                    u = x + p;
                }
                if ((double)(z) < (double)(0))
                {
                    sgngam = -1;
                    z = -z;
                }
                else
                {
                    sgngam = 1;
                }
                if ((double)(u) == (double)(2))
                {
                    result = Math.Log(z);
                    return result;
                }
                p = p - 2;
                x = x + p;
                b = -1378.25152569120859100;
                b = -38801.6315134637840924 + x * b;
                b = -331612.992738871184744 + x * b;
                b = -1162370.97492762307383 + x * b;
                b = -1721737.00820839662146 + x * b;
                b = -853555.664245765465627 + x * b;
                c = 1;
                c = -351.815701436523470549 + x * c;
                c = -17064.2106651881159223 + x * c;
                c = -220528.590553854454839 + x * c;
                c = -1139334.44367982507207 + x * c;
                c = -2532523.07177582951285 + x * c;
                c = -2018891.41433532773231 + x * c;
                p = x * b / c;
                result = Math.Log(z) + p;
                return result;
            }
            q = (x - 0.5) * Math.Log(x) - x + ls2pi;
            if ((double)(x) > (double)(100000000))
            {
                result = q;
                return result;
            }
            p = 1 / (x * x);
            if ((double)(x) >= (double)(1000.0))
            {
                q = q + ((7.9365079365079365079365 * 0.0001 * p - 2.7777777777777777777778 * 0.001) * p + 0.0833333333333333333333) / x;
            }
            else
            {
                a = 8.11614167470508450300 * 0.0001;
                a = -(5.95061904284301438324 * 0.0001) + p * a;
                a = 7.93650340457716943945 * 0.0001 + p * a;
                a = -(2.77777777730099687205 * 0.001) + p * a;
                a = 8.33333333333331927722 * 0.01 + p * a;
                q = q + a / x;
            }
            result = q;
            return result;
        }
        public static double incompletegamma(double a, double x)
        {
            double result = 0;
            double igammaepsilon = 0;
            double ans = 0;
            double ax = 0;
            double c = 0;
            double r = 0;
            double tmp = 0;

            igammaepsilon = 0.000000000000001;
            if ((double)(x) <= (double)(0) | (double)(a) <= (double)(0))
            {
                result = 0;
                return result;
            }
            if ((double)(x) > (double)(1) & (double)(x) > (double)(a))
            {
                result = 1 - incompletegammac(a, x);
                return result;
            }
            ax = a * Math.Log(x) - x - lngamma(a, ref tmp);
            if ((double)(ax) < (double)(-709.78271289338399))
            {
                result = 0;
                return result;
            }
            ax = Math.Exp(ax);
            r = a;
            c = 1;
            ans = 1;
            do
            {
                r = r + 1;
                c = c * x / r;
                ans = ans + c;
            }
            while ((double)(c / ans) > (double)(igammaepsilon));
            result = ans * ax / a;
            return result;
        }
        public static double incompletegammac(double a, double x)
        {
            double result = 0;
            double igammaepsilon = 0;
            double igammabignumber = 0;
            double igammabignumberinv = 0;
            double ans = 0;
            double ax = 0;
            double c = 0;
            double yc = 0;
            double r = 0;
            double t = 0;
            double y = 0;
            double z = 0;
            double pk = 0;
            double pkm1 = 0;
            double pkm2 = 0;
            double qk = 0;
            double qkm1 = 0;
            double qkm2 = 0;
            double tmp = 0;

            igammaepsilon = 0.000000000000001;
            igammabignumber = 4503599627370496.0;
            igammabignumberinv = 2.22044604925031308085 * 0.0000000000000001;
            if ((double)(x) <= (double)(0) | (double)(a) <= (double)(0))
            {
                result = 1;
                return result;
            }
            if ((double)(x) < (double)(1) | (double)(x) < (double)(a))
            {
                result = 1 - incompletegamma(a, x);
                return result;
            }
            ax = a * Math.Log(x) - x - lngamma(a, ref tmp);
            if ((double)(ax) < (double)(-709.78271289338399))
            {
                result = 0;
                return result;
            }
            ax = Math.Exp(ax);
            y = 1 - a;
            z = x + y + 1;
            c = 0;
            pkm2 = 1;
            qkm2 = x;
            pkm1 = x + 1;
            qkm1 = z * x;
            ans = pkm1 / qkm1;
            do
            {
                c = c + 1;
                y = y + 1;
                z = z + 2;
                yc = y * c;
                pk = pkm1 * z - pkm2 * yc;
                qk = qkm1 * z - qkm2 * yc;
                if ((double)(qk) != (double)(0))
                {
                    r = pk / qk;
                    t = Math.Abs((ans - r) / r);
                    ans = r;
                }
                else
                {
                    t = 1;
                }
                pkm2 = pkm1;
                pkm1 = pk;
                qkm2 = qkm1;
                qkm1 = qk;
                if ((double)(Math.Abs(pk)) > (double)(igammabignumber))
                {
                    pkm2 = pkm2 * igammabignumberinv;
                    pkm1 = pkm1 * igammabignumberinv;
                    qkm2 = qkm2 * igammabignumberinv;
                    qkm1 = qkm1 * igammabignumberinv;
                }
            }
            while ((double)(t) > (double)(igammaepsilon));
            result = ans * ax;
            return result;
        }
    }
}
