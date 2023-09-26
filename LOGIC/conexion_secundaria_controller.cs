using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
    public class conexion_secundaria_controller
    {

        public static int comprobar_conexion(string cadena_de_conexion)
        {
            try
            {
                SqlConnection conexionManual = new SqlConnection(cadena_de_conexion);
                conexionManual.Open();
                SqlCommand da = new SqlCommand("select idUsuario from USUARIO2", conexionManual);
                return Convert.ToInt32(da.ExecuteScalar());
            }
            catch (Exception ex)
            {
                //Escribes en el log de eventos que algo salio mal al comprobar la conexion
                throw ex;
            }
        }

        public static SqlConnection obtenerSQL_conexion(string cadena_de_conexion)
        {
            try
            {
                SqlConnection conexionManual = new SqlConnection(cadena_de_conexion);
                conexionManual.Open();
                return conexionManual;
            }
            catch (Exception ex)
            {
                //Escribes en el log de eventos que algo salio mal al comprobar la conexion
                throw ex;
            }
        }
    }
}
