using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.CONEXION;
using System.Windows.Forms;
namespace PUNTO_DE_VENTA.DATE
{
    class Editar_datos
    {
        public static void cambio_de_caja(int idcaja, int idventa)
        {
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("cambio_de_Caja", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcaja", idcaja);
            cmd.Parameters.AddWithValue("@idventa", idventa);
            cmd.ExecuteNonQuery();
            CONEXIONMAESTRA.cerrar();
        }
        public static void ingresar_nombre_a_venta_en_espera(int idventa, string nombre)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("ingresar_nombre_a_venta_en_espera", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idventa);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
