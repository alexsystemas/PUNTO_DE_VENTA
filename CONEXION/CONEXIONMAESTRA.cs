using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.CONEXION
{
    class CONEXIONMAESTRA
    {  // creamos la conexion hacia la BD

        public static string conexion =Convert.ToString(CONEXION.Desencryptacion.checkServer());
       // public static string conexion = @"Data source=DESKTOP-VBGGJBO;Initial Catalog=BASE_PUNTO_VENTA;Integrated Security=True";

    }
}
