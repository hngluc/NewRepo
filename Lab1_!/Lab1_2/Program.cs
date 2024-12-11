using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        internal static double calc(string formula)
        {
            try
            {
                DataTable table = new DataTable();
                object result = table.Compute(formula, string.Empty);
                return Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid formula", ex);
            }
        }
    }
}
