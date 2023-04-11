using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA
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
            Application.Run(new MODULOS.REPORTES.REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.FormInventariosTodos());
        }
    }
}
