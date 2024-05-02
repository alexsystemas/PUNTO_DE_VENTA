using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;
namespace PUNTO_DE_VENTA.DATE
{
    public class Dcompras
    {
        int idCaja;
        public bool insertar_compras(LDetalleCompra  parametros)
        {
            try
            {
                var funcion = new Dcaja();
                funcion.ObtenerIdCaja(ref idCaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechacompra", DateTime.Now);
                cmd.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);
                cmd.Parameters.AddWithValue("@Costo", parametros.Costo);
                cmd.Parameters.AddWithValue("@Moneda", parametros.Moneda);
                cmd.Parameters.AddWithValue("@IdProducto", parametros.IdProducto);
                cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@Idcaja", idCaja);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }

        public void mostrarUltimoIdcompra(ref int idcompra)
        {
            try
            {
                var funcion = new Dcaja();
                funcion.ObtenerIdCaja(ref idCaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand com = new SqlCommand("MostrarUltimoIdcompra", CONEXIONMAESTRA.conectar);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Idcaja", idCaja);
                idcompra = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {

                idcompra = 0;
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();

            }
        }
    }
}
