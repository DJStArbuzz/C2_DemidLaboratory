using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SimpleSignal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создание и отображение Form1
            Form1 form1 = new Form1();
            form1.Show();

            // Создание и отображение MainForm
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
