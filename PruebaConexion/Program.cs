using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Servidor;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Servidor.frmServidor server = new frmServidor(); 
            //Application.Run(new Form1());
             Application.Run(new FormMenu());
            //Application.Run(new frmPrincipal() );
            
        }
    }
}
