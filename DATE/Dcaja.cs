using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.DATE
{
   public class Dcaja
    {
        string serialPC;
        public void ObtenerIdCaja(ref int idcaja)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlCommand con = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", CONEXIONMAESTRA.conectar);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Serial", serialPC);
                idcaja = Convert.ToInt32(con.ExecuteScalar());

            }
            catch (Exception ex)
            {
                idcaja = 0;
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
