using System;
using System.Windows.Forms;

namespace adminPanel
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
            // Starter en instans av LoginForm
            LoginForm lf = new LoginForm();
            // Sjekker om innlogging var vellykket
            if (lf.ShowDialog() == DialogResult.OK)
            {
                // Starter MainForm
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}