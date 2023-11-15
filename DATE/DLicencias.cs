using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.DATE
{
    public class DLicencias
    {
        DateTime fechaFinal;
        DateTime FechaInicial;
        string estado;
        string SerialPcLicencia;
        DateTime fechaSistema = DateTime.Today;
        string SerialPC;
        public void ValidarLicencias(ref string Resultado, ref string ResultFechafinal)
        {
            try
            {
                Bases.Obtener_serialPC(ref SerialPC);
                MessageBox.Show("" + SerialPC);
                DataTable dt = new DataTable();
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Marcan", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
                foreach (DataRow rdr in dt.Rows)
                {


                    estado = Bases.Desencriptar(rdr["E"].ToString());

                    fechaFinal = Convert.ToDateTime(Bases.Desencriptar(rdr["F"].ToString()));

                    FechaInicial = Convert.ToDateTime(Bases.Desencriptar(rdr["FA"].ToString())).Date;

                    SerialPcLicencia = (rdr["S"].ToString());





                }

                if (estado == "VENCIDA")
                {
                    Resultado = "VENCIDA";

                }
                else
                {
                    if (fechaFinal >= fechaSistema)
                    {


                        if (FechaInicial <= fechaSistema)
                        {
                            if (SerialPcLicencia == SerialPC)
                            {
                                Resultado = estado;
                                ResultFechafinal = fechaFinal.ToString("dd/MM/yyyy");


                            }
                        }
                        else
                        {
                            Resultado = "VENCIDA";
                        }
                    }
                    else
                    {
                        Resultado = "VENCIDA";
                    }
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void EditarMarcanVencidas()
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("MarcanVencidas", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@E", Bases.Encriptar("VENCIDA"));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();

            }
        }
    }

}



