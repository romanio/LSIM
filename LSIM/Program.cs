using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace LSIM
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Десятичный разделитель точка
            // Без разделителя разрядов

            CultureInfo cInfo = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            cInfo.NumberFormat.NumberDecimalSeparator = ".";
            cInfo.NumberFormat.NumberGroupSeparator = "";
            Thread.CurrentThread.CurrentCulture = cInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CenterScreen());
        }
    }
}
 