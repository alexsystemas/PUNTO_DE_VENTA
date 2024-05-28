using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PUNTO_DE_VENTA.CONEXION;
using PUNTO_DE_VENTA.LOGIC;



namespace PUNTO_DE_VENTA.DATE
{
   public  class DIniciosSeccion
    {
        string serialpc;
        public void mostrar_inicio_De_sesion(ref int idusuario)
        {
            Bases.Obtener_serialPC(ref serialpc);
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_inicio_De_sesion", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_serial_pc", serialpc);
                idusuario = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                idusuario = 0;
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
