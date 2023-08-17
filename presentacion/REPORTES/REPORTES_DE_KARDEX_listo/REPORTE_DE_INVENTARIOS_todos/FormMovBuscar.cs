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
    public partial class FormMovBuscar : Form
    {
        public FormMovBuscar()
        {
            InitializeComponent();
        }
        ReportMovBuscar rptReport2 = new ReportMovBuscar();
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
                da = new SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idProducto", sevendePor.INVENTARIOS_KARDEX.INVENTARIO_MENU.idProducto);
                da.Fill(dt);
                con.Close();
                rptReport2 = new ReportMovBuscar();
                rptReport2.DataSource = dt;
                reportViewer1.Report = rptReport2;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

            private void FormMovBuscar_Load(object sender, EventArgs e)
        {
                mostrar();
        }

       
    }
}
