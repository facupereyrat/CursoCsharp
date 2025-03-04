using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CursoCsharp.OperadoresAritmeticos;
using CursoCsharp.OperadoresRelacionales;
using CursoCsharp.OperadoresLogicos;
using CursoCsharp.Ejercicios;
using CursoCsharp.Condicionales;
using CursoCsharp.Listas;

namespace CursoCsharp
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
            Application.Run(new Frmlistas());
        }
    }
}
