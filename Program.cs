using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //static void Main(string[] args)
        //{
        //    Contexto _switch = new Contexto();

        //    _switch.Presionar();
        //    _switch.Presionar();
        //    _switch.Presionar();
        //    _switch.Presionar();
        //    _switch.Presionar();
        //    _switch.Presionar();


        //    Console.ReadKey();
        //}

    }
}
