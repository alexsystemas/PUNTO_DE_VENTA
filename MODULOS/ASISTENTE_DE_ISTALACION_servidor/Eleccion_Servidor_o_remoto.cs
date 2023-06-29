using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PUNTO_DE_VENTA.MODULOS.ASISTENTE_DE_ISTALACION_servidor
{
    public partial class Eleccion_Servidor_o_remoto : Form
    {
        public Eleccion_Servidor_o_remoto()
        {
            InitializeComponent();
        }
        string Estado_de_concexion;
        private void Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("select * from USUARIO2 ", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                Estado_de_concexion = "CONECTADO";
            }
            catch (Exception ex)
            {
                Estado_de_concexion = "-";
               
            }
        }

        private void Eleccion_Servidor_o_remoto_Load(object sender, EventArgs e)
        {
            panel5.Location= new Point((Width - panel5.Width) / 2,(Height - panel5.Height) / 2);
            Listar();
            if(Estado_de_concexion == "CONECTADO")
            {
                Dispose();
                MODULOS.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA frm = new MODULOS.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA();
                frm.ShowDialog();
            }
        }

        private void BtnServidor_Click(object sender, EventArgs e)
        {
            Dispose();
            MODULOS.ASISTENTE_DE_ISTALACION_servidor.Instalacion_del_servidorSQL frm = new MODULOS.ASISTENTE_DE_ISTALACION_servidor.Instalacion_del_servidorSQL();
            frm.ShowDialog();

        }
    }
}
