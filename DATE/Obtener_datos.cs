using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;
using System.Data.SqlClient;
using System.Data;
namespace PUNTO_DE_VENTA.DATE
{
    class Obtener_datos
    {
        private static string serialPC;
        public static void obtener_id_caja_PorSerial(ref int idcaja)
        {
            Bases.Obtener_serialPC(ref serialPC);
           
                CONEXIONMAESTRA.abrir();
                SqlCommand com = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", CONEXIONMAESTRA.conectar);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Serial", serialPC);
                idcaja =Convert.ToInt32 (com.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
           
        }

        public static void mostrar_ventas_en_espera_con_fecha_y_monto(ref DataTable dt)
        {
           
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ventas_en_espera_con_fecha_y_monto", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
           
        }
        public static void mostrar_productos_agregados_a_ventas_en_espera(ref DataTable dt, int idventa)
        {
            CONEXIONMAESTRA.abrir();
            SqlDataAdapter da = new SqlDataAdapter("mostrar_productos_agregados_a_ventas_en_espera", CONEXIONMAESTRA.conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
            da.Fill(dt);
            CONEXIONMAESTRA.cerrar();

        }
        public static void buscar_conceptos(ref DataTable dt, string buscador)
        {
            CONEXIONMAESTRA.abrir();
            SqlDataAdapter da = new SqlDataAdapter("buscar_conceptos", CONEXIONMAESTRA.conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
            da.Fill(dt);
            CONEXIONMAESTRA.cerrar();
        }
    }
}
