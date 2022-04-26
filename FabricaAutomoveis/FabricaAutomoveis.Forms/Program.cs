using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FabricaAutomoveis.Forms
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
            BOCALogin.setConexao("[famema.famema].teste");
            Application.Run(new DTIFormPadrao());
        }
    }
}
