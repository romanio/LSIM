namespace LSIM
{
    partial class CenterScreen
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.boxDepression = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.boxWaterVisc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boxOilVisc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxLines = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxPermMean = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxPermV2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxKRW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxSOWC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxSWCR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxPoro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set model ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetModelOnClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 583);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listOutput);
            this.tabPage1.Controls.Add(this.boxDepression);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.boxWaterVisc);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.boxOilVisc);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.boxLines);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.boxPermMean);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.boxPermV2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.boxKRW);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.boxSOWC);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.boxSWCR);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.boxPoro);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.boxWidth);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.boxHeight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.boxLength);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listOutput
            // 
            this.listOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(226, 466);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(425, 108);
            this.listOutput.TabIndex = 31;
            // 
            // boxDepression
            // 
            this.boxDepression.Location = new System.Drawing.Point(110, 476);
            this.boxDepression.Name = "boxDepression";
            this.boxDepression.Size = new System.Drawing.Size(100, 21);
            this.boxDepression.TabIndex = 30;
            this.boxDepression.Text = "20.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Depression, atm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(18, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "System properties";
            // 
            // boxWaterVisc
            // 
            this.boxWaterVisc.Location = new System.Drawing.Point(110, 395);
            this.boxWaterVisc.Name = "boxWaterVisc";
            this.boxWaterVisc.Size = new System.Drawing.Size(100, 21);
            this.boxWaterVisc.TabIndex = 27;
            this.boxWaterVisc.Text = "0.7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Water visc, cP";
            // 
            // boxOilVisc
            // 
            this.boxOilVisc.Location = new System.Drawing.Point(110, 366);
            this.boxOilVisc.Name = "boxOilVisc";
            this.boxOilVisc.Size = new System.Drawing.Size(100, 21);
            this.boxOilVisc.TabIndex = 25;
            this.boxOilVisc.Text = "12.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 369);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Oil visc, cP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(18, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fluids properties";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(18, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Reservoir properties";
            // 
            // boxLines
            // 
            this.boxLines.Location = new System.Drawing.Point(110, 296);
            this.boxLines.Name = "boxLines";
            this.boxLines.Size = new System.Drawing.Size(100, 21);
            this.boxLines.TabIndex = 21;
            this.boxLines.Text = "500";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lines";
            // 
            // boxPermMean
            // 
            this.boxPermMean.Location = new System.Drawing.Point(110, 242);
            this.boxPermMean.Name = "boxPermMean";
            this.boxPermMean.Size = new System.Drawing.Size(100, 21);
            this.boxPermMean.TabIndex = 19;
            this.boxPermMean.Text = "50.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Perm mean, mD";
            // 
            // boxPermV2
            // 
            this.boxPermV2.Location = new System.Drawing.Point(110, 269);
            this.boxPermV2.Name = "boxPermV2";
            this.boxPermV2.Size = new System.Drawing.Size(100, 21);
            this.boxPermV2.TabIndex = 17;
            this.boxPermV2.Text = "0.600";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Perms V2";
            // 
            // boxKRW
            // 
            this.boxKRW.Location = new System.Drawing.Point(110, 215);
            this.boxKRW.Name = "boxKRW";
            this.boxKRW.Size = new System.Drawing.Size(100, 21);
            this.boxKRW.TabIndex = 15;
            this.boxKRW.Text = "0.200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Krw";
            // 
            // boxSOWC
            // 
            this.boxSOWC.Location = new System.Drawing.Point(110, 188);
            this.boxSOWC.Name = "boxSOWC";
            this.boxSOWC.Size = new System.Drawing.Size(100, 21);
            this.boxSOWC.TabIndex = 13;
            this.boxSOWC.Text = "0.35";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sowc";
            // 
            // boxSWCR
            // 
            this.boxSWCR.Location = new System.Drawing.Point(110, 161);
            this.boxSWCR.Name = "boxSWCR";
            this.boxSWCR.Size = new System.Drawing.Size(100, 21);
            this.boxSWCR.TabIndex = 11;
            this.boxSWCR.Text = "0.20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Swcr";
            // 
            // boxPoro
            // 
            this.boxPoro.Location = new System.Drawing.Point(110, 134);
            this.boxPoro.Name = "boxPoro";
            this.boxPoro.Size = new System.Drawing.Size(100, 21);
            this.boxPoro.TabIndex = 9;
            this.boxPoro.Text = "0.06";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Porosity";
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(110, 107);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(100, 21);
            this.boxWidth.TabIndex = 7;
            this.boxWidth.Text = "15.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width model, m";
            // 
            // boxHeight
            // 
            this.boxHeight.Location = new System.Drawing.Point(110, 78);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(100, 21);
            this.boxHeight.TabIndex = 5;
            this.boxHeight.Text = "10.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height model, m";
            // 
            // boxLength
            // 
            this.boxLength.Location = new System.Drawing.Point(110, 49);
            this.boxLength.Name = "boxLength";
            this.boxLength.Size = new System.Drawing.Size(100, 21);
            this.boxLength.TabIndex = 3;
            this.boxLength.Text = "500.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length model, m";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea1.AxisX.LabelStyle.Format = "N1";
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleView.MinSize = 0D;
            chartArea1.AxisX.ScaleView.SmallScrollMinSize = 0D;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.Title = "Permability, mD";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea1.AxisY.LabelStyle.Format = "N1";
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.ScaleView.MinSize = 0D;
            chartArea1.AxisY.ScaleView.SmallScrollMinSize = 0D;
            chartArea1.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisY.Title = "Height, m";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea1.CursorX.Interval = 0.01D;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.CursorY.Interval = 0.01D;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(226, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(425, 437);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart4);
            this.tabPage2.Controls.Add(this.chart3);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3.BorderlineColor = System.Drawing.Color.Black;
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea3.AxisX.LabelStyle.Format = "N1";
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.ScaleView.MinSize = 0D;
            chartArea3.AxisX.ScaleView.SmallScrollMinSize = 0D;
            chartArea3.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea3.AxisX.Title = "Kz";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea3.AxisY.LabelStyle.Format = "N1";
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.ScaleView.MinSize = 0D;
            chartArea3.AxisY.ScaleView.SmallScrollMinSize = 0D;
            chartArea3.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea3.AxisY.Title = "Height, m";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea3.CursorX.Interval = 0.01D;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea3.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.CursorY.Interval = 0.01D;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea3.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(6, 319);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerSize = 7;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            this.chart3.Series.Add(series4);
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(381, 232);
            this.chart3.TabIndex = 25;
            this.chart3.Text = "chart3";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sec",
            "Day",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(143, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(18, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Time";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(116, 21);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea4.AxisX.LabelStyle.Format = "N1";
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.ScaleView.MinSize = 0D;
            chartArea4.AxisX.ScaleView.SmallScrollMinSize = 0D;
            chartArea4.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea4.AxisX.Title = "Length, m";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea4.AxisY.LabelStyle.Format = "N1";
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.ScaleView.MinSize = 0D;
            chartArea4.AxisY.ScaleView.SmallScrollMinSize = 0D;
            chartArea4.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea4.AxisY.Title = "Height, m";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea4.CursorX.Interval = 0.01D;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea4.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.CursorY.Interval = 0.01D;
            chartArea4.CursorY.IsUserSelectionEnabled = true;
            chartArea4.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea4.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(6, 70);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.MarkerSize = 7;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Series1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.Name = "Series2";
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(763, 243);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart4
            // 
            this.chart4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea2.AxisX.LabelStyle.Format = "N1";
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.ScaleView.MinSize = 0D;
            chartArea2.AxisX.ScaleView.SmallScrollMinSize = 0D;
            chartArea2.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisX.Title = "Kz";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea2.AxisY.LabelStyle.Format = "N1";
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.ScaleView.MinSize = 0D;
            chartArea2.AxisY.ScaleView.SmallScrollMinSize = 0D;
            chartArea2.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisY.Title = "Height, m";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 7.5F);
            chartArea2.CursorX.Interval = 0.01D;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea2.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.CursorY.Interval = 0.01D;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea2.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart4.Legends.Add(legend2);
            this.chart4.Location = new System.Drawing.Point(393, 319);
            this.chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.chart4.Series.Add(series2);
            this.chart4.Series.Add(series3);
            this.chart4.Size = new System.Drawing.Size(376, 232);
            this.chart4.TabIndex = 26;
            this.chart4.Text = "chart4";
            // 
            // CenterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 607);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CenterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LSIM";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxLength;
        private System.Windows.Forms.TextBox boxSOWC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxSWCR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxPoro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxPermV2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxKRW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxPermMean;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxLines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxWaterVisc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boxOilVisc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxDepression;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

