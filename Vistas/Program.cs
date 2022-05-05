using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
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
            var fLogin = new FrmLogin();
            fLogin.FormClosed += FormClosed;
            fLogin.Show();
            Application.Run();
            //Application.Run(new FrmMain());
            //Application.Run(new FrmAltaClientes());
            //Application.Run(new FrmAltaObrasSociales());
            //Application.Run(new FrmAltaProductos());
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
