using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
       
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}