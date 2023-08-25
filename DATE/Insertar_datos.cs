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
    class Insertar_datos
    {
        public static void insertar_Conceptos(string descripcion)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Conceptos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public static void insertar_Gastos_varios(DateTime fecha, string Nro_comprobante,
            string tipo_comprobante, double importe, string descripcion, int id_Caja, int id_Concepto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Gastos_varios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Nro_comprobante", Nro_comprobante);
                cmd.Parameters.AddWithValue("@Tipo_comprobante", tipo_comprobante);
                cmd.Parameters.AddWithValue("@Importe", importe);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Id_caja", id_Caja);
                cmd.Parameters.AddWithValue("@Id_concepto", id_Concepto);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
