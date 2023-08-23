using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PUNTO_DE_VENTA.CONEXION;
using System.Windows.Forms;
namespace PUNTO_DE_VENTA.DATE
{
    class Eliminar_datos
    {
        public static void eliminar_venta(int idventa)
        {
            try
            {
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("eliminar_venta", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idventa", idventa);
            cmd.ExecuteNonQuery();
            CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

    }
}
