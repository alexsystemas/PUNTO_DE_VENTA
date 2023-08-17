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
namespace PUNTO_DE_VENTA.sevendePor.REPORTES.REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos
{
    public partial class FormInventariosTodos : Form
    {
        public FormInventariosTodos()
        {
            InitializeComponent();
        }
        reportInventarios_Todos rptReport2 = new reportInventarios_Todos();
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                da = new SqlDataAdapter("imprimir_inventarios_todos", con);
                da.Fill(dt);
                con.Close();
                rptReport2 = new reportInventarios_Todos();
                rptReport2.DataSource = dt;
                rptReport2.table1.DataSource = dt;
                reportViewer1.Report = rptReport2;
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            




        }

        private void FormInventariosTodos_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
