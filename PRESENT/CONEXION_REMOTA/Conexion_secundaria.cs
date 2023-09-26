using PUNTO_DE_VENTA.CONEXION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.PRESENT.CONEXION_REMOTA
{
    public partial class Conexion_secundaria : Form
    {
        //conexion_secundaria_controller ctr = new conexion_secundaria_controller();

        public Conexion_secundaria()
        {
            InitializeComponent();
        }
        string cadena_de_conexion;
        int id;
        string indicador_de_conexion;
        private AES aes = new AES();
        int idCaja=0;
        string serialPC;
        private void Btn_Conectar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIp.Text))
            {
                conectar_manualmente();

            }
            else
            {
                MessageBox.Show("Ingresa la IP", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void comprobar_conexion()
        {
            try
            {
                /*
                id = conexion_secundaria_controller.comprobar_conexion(cadena_de_conexion);
                indicador_de_conexion = "HAY CONEXION";
                */
                SqlConnection conexionManual = new SqlConnection(cadena_de_conexion);
                conexionManual.Open();
                SqlCommand da = new SqlCommand("select idUsuario from USUARIO2", conexionManual);
                id = Convert.ToInt32(da.ExecuteScalar());
                indicador_de_conexion = "HAY CONEXION";
                
            }
            catch (Exception)
            {
                indicador_de_conexion = "NO HAY CONEXION";
            }
        }

        private void conectar_manualmente()
        {
            string IP = txtIp.Text;
            cadena_de_conexion = "Data Source =" + IP + ";Initial Catalog=BASE_PUNTO_VENTA;Integrated Security=False;User Id=conexion_remota;Password=12345678";
            comprobar_conexion();
            if (indicador_de_conexion == "HAY CONEXION")
            {
                SavetoXML(aes.Encrypt(cadena_de_conexion, Desencryptacion.appPwdUnique, int.Parse("256")));
                obtenerIdCaja();
                if (idCaja > 0)
                {
                    MessageBox.Show("Conexion Correcta. Vuelve a Abrir el Sistema", "Conexion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    Caja_secundaria.lblconexion = cadena_de_conexion;
                    Dispose();
                    Caja_secundaria frm = new Caja_secundaria();
                    frm.ShowDialog();
                }
            }
        }

        private void obtenerIdCaja()
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);

                //SqlConnection conexionExpress = conexion_secundaria_controller.obtenerSQL_conexion(cadena_de_conexion);
                SqlConnection conexionExpress = new SqlConnection(cadena_de_conexion);
                conexionExpress.Open();
                SqlCommand com = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", conexionExpress);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Serial", serialPC);
                idCaja = Convert.ToInt32(com.ExecuteScalar());
                conexionExpress.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    
       
       
        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        private void Conexion_secundaria_Load(object sender, EventArgs e)
        {

        }
    }
}
