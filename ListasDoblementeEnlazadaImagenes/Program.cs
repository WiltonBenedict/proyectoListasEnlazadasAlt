using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDoblementeEnlazadaImagenes
{
    internal static class Program
    {
        //Universidad Hispanoamericana
        //Estructura de Datos, INFO-105.
        //Proyecto Programado II
        //Est. Wilton Benedict Castillo
        //Est. Leandro Bonilla Lobo
        //Est. Johan Araya Retana
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
    }
}
