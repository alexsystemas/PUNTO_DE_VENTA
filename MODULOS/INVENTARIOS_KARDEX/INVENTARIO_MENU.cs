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
using System.Globalization;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace PUNTO_DE_VENTA.MODULOS.INVENTARIOS_KARDEX
{
    public partial class INVENTARIO_MENU : Form
    {
        public INVENTARIO_MENU()
        {
            InitializeComponent();
        }
        private void buscar_productos_movimientos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("BUSCAR_PRODUCTOS_KARDEX", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letrab", txtBuscarMovimiento.Text);
                da.Fill(dt);
                DATALISTADO_PRODUCTOS_Movimientos.DataSource = dt;
                con.Close();


                DATALISTADO_PRODUCTOS_Movimientos.Columns[1].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[3].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[4].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[5].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[6].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[7].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[8].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[9].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[10].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[11].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[12].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[13].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[14].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[15].Visible = false;
                DATALISTADO_PRODUCTOS_Movimientos.Columns[16].Visible = false;

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref DATALISTADO_PRODUCTOS_Movimientos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MOSTRAR_Inventarios_bajo_minimo()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_Inventarios_bajo_minimo", con);
               
                da.Fill(dt);
                dataListadoInventarioBAJO.DataSource = dt;
                con.Close();


                dataListadoInventarioBAJO.Columns[0].Visible = false;
                dataListadoInventarioBAJO.Columns[4].Visible = false;
                dataListadoInventarioBAJO.Columns[7].Visible = false;
                dataListadoInventarioBAJO.Columns[8].Visible = false;
                dataListadoInventarioBAJO.Columns[9].Visible = false;
                

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoInventarioBAJO);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TxtBuscarMovimiento_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarMovimiento.Text == "Buscar Producto" | txtBuscarMovimiento.Text == "")
            {
                DATALISTADO_PRODUCTOS_Movimientos.Visible = false;

            }
            else
            {
                DATALISTADO_PRODUCTOS_Movimientos.Visible = true;
                buscar_productos_movimientos();
            }


        }

        private void DATALISTADO_PRODUCTOS_Movimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscarMovimiento.Text = DATALISTADO_PRODUCTOS_Movimientos.SelectedCells[2].Value.ToString();
            DATALISTADO_PRODUCTOS_Movimientos.Visible = false;
            buscar_MOVIMIENTOS_DE_KARDEX();
        }
        private void buscar_MOVIMIENTOS_DE_KARDEX()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idProducto", DATALISTADO_PRODUCTOS_Movimientos.SelectedCells[1].Value.ToString());
                da.Fill(dt);
               dataListadoMovimientos.DataSource = dt;
                con.Close();


               dataListadoMovimientos.Columns[0].Visible = false;
               dataListadoMovimientos.Columns[10].Visible = false;
               dataListadoMovimientos.Columns[11].Visible = false;
                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoMovimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buscar_MOVIMIENTOS_FILTROS()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", txtfechaM.Value);
                da.SelectCommand.Parameters.AddWithValue("@tipo", txtTipoMovi.Text);
                da.SelectCommand.Parameters.AddWithValue("@Id_usuario", txtIdusuarios.Text);


                da.Fill(dt);
                dataListadoMovimientos.DataSource = dt;
                con.Close();


                dataListadoMovimientos.Columns[0].Visible = false;
                dataListadoMovimientos.Columns[10].Visible = false;
                dataListadoMovimientos.Columns[11].Visible = false;

                dataListadoMovimientos.Columns[9].Visible = false;
                dataListadoMovimientos.Columns[13].Visible = false;
                dataListadoMovimientos.Columns[14].Visible = false;
                dataListadoMovimientos.Columns[12].Visible = false;
                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoMovimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buscar_MOVIMIENTOS_FILTROS_ACUMULADO()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", txtfechaM.Value);
                da.SelectCommand.Parameters.AddWithValue("@tipo", txtTipoMovi.Text);
                da.SelectCommand.Parameters.AddWithValue("@Id_usuario", txtIdusuarios.Text);


                da.Fill(dt);
                dataListadoMovimimientosAcumulado_Producto.DataSource = dt;
                con.Close();


                dataListadoMovimimientosAcumulado_Producto.Columns[4].Visible = false;
                dataListadoMovimimientosAcumulado_Producto.Columns[5].Visible = false;
                dataListadoMovimimientosAcumulado_Producto.Columns[6].Visible = false;

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoMovimimientosAcumulado_Producto);
                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
                styCabeceras.ForeColor = System.Drawing.Color.White;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataListadoMovimimientosAcumulado_Producto.ColumnHeadersDefaultCellStyle = styCabeceras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            DATALISTADO_PRODUCTOS_Movimientos.Visible = false;
            txtTipoMovi.Text = "-Todos-";
            buscar_MOVIMIENTOS_FILTROS();
            buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            panel10.Visible = true;
            btnImprimirGrup.Visible = false;
            btnFiltroAvanzado.Visible = false;
        }


        private void TxtfechaM_ValueChanged(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                buscar_MOVIMIENTOS_FILTROS();
                buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            }
        }

        private void TxtTipoMovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                buscar_MOVIMIENTOS_FILTROS();
                buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            }
        }

        private void TxtUSUARIOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                Buscar_id_USUARIOS();
                buscar_MOVIMIENTOS_FILTROS();
                buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            }
        }



        internal void Buscar_id_USUARIOS()
        {

            string resultado;
            string queryMoneda;
            queryMoneda = "Buscar_id_USUARIO";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            comMoneda.CommandType = CommandType.StoredProcedure;
            comMoneda.Parameters.AddWithValue("@Nombres_y_Apellidos", txtUSUARIOS.Text);
            try
            {
                con.Open();
                resultado = Convert.ToString(comMoneda.ExecuteScalar()); //asignamos el valor del importe
               txtIdusuarios.Text = resultado;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                resultado = "";
            }
        }
        private void buscar_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("select * from USUARIO2", con);
               
                da.Fill(dt);
                txtUSUARIOS.DisplayMember = "Nombres_y_Apellidos";
                txtUSUARIOS.ValueMember = "idUsuario";

                txtUSUARIOS.DataSource = dt;
                //txtIdusuario.Text = txtUSUARIOS.ValueMember;

                con.Close();
                Buscar_id_USUARIOS();
            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message);

            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            groupBox1.Visible = false;
            buscar_MOVIMIENTOS_DE_KARDEX();
            txtTipoMovi.Text = "Todos-";
            txtBuscarMovimiento.Text = "Buscar Producto";
            btnImprimir.Visible = true;
            btnFiltroAvanzado.Visible = true;


        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            pnlMovimentos.Dock = DockStyle.None;
            panelREPORTEInventario.Dock = DockStyle.None;
            panelINVENTARIObajo.Dock = DockStyle.Fill;
            panelVencimiento.Dock = DockStyle.None;
            pnlMovimentos.Visible = false;
            panelREPORTEInventario.Visible = false;
            panelINVENTARIObajo.Visible = true;
            panelVencimiento.Visible = false;
            panelKardex.Visible = false;
            panelKardex.Dock = DockStyle.None;

            pnKardex.Visible = false;
            pnMovimientos.Visible = false;
            pnInventariosBajos.Visible = true;
            pnReporteDeInventarios.Visible = false;
            pnVencimientos.Visible = false;

            MOSTRAR_Inventarios_bajo_minimo();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtbuscar_inventarios.Text != "Buscar...")
            {
                mostrar_inventario_todos();
            }

        }

        internal void sumar_costo_de_inventario_CONTAR_PRODUCTOS()
        {

    

            string resultado;
            string queryMoneda;
            queryMoneda = "SELECT Moneda  FROM EMPRESA";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            try
            {
                con.Open();
                resultado = Convert.ToString(comMoneda.ExecuteScalar()); //asignamos el valor del importe
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                resultado = "";
            }

            string importe;
            string query;
            query = "SELECT      CONVERT(NUMERIC(18,2),sum(Producto1.Precio_de_compra * Stock )) as suma FROM  Producto1 where  Usa_inventarios ='SI'";

            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open();
                importe = Convert.ToString(com.ExecuteScalar()); //asignamos el valor del importe
                con.Close();
                lblcosotoInventario.Text = resultado + " " + importe;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                lblcosotoInventario.Text = resultado + " " + 0;
            }

            string conteoresultado;
            string querycontar;
            querycontar = "select count(Id_Producto1 ) from Producto1 ";
            SqlCommand comcontar = new SqlCommand(querycontar, con);
            try
            {
                con.Open();
                conteoresultado = Convert.ToString(comcontar.ExecuteScalar()); //asignamos el valor del importe
                con.Close();
                lblcantidaddeProductosEnInventario.Text = conteoresultado;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                conteoresultado = "";
                lblcantidaddeProductosEnInventario.Text = "0";
            }

        }

        private void mostrar_inventario_todos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_inventarios_todos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar_inventarios.Text);

                da.Fill(dt);
                dataListadoInventarioReport.DataSource = dt;
                con.Close();


                dataListadoInventarioReport.Columns[0].Visible = false;
                dataListadoInventarioReport.Columns[9].Visible = false;
                dataListadoInventarioReport.Columns[10].Visible = false;

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoInventarioReport);
                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
                styCabeceras.ForeColor = System.Drawing.Color.White;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataListadoInventarioReport.ColumnHeadersDefaultCellStyle = styCabeceras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReportInventarios_Click(object sender, EventArgs e)
        {

            pnlMovimentos.Dock = DockStyle.None;
            panelREPORTEInventario.Dock = DockStyle.Fill;
            panelINVENTARIObajo.Dock = DockStyle.None;
            panelVencimiento.Dock = DockStyle.None;
            pnlMovimentos.Visible = false;
            panelREPORTEInventario.Visible = true;
            panelINVENTARIObajo.Visible = false;
            panelVencimiento.Visible = false;
            panelKardex.Visible = false;
            panelKardex.Dock = DockStyle.None;

            pnKardex.Visible = false;
            pnMovimientos.Visible = false;
            pnInventariosBajos.Visible = false;
            pnReporteDeInventarios.Visible = true;
            pnVencimientos.Visible = false;

            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtbuscar_inventarios.Clear();
            mostrar_inventario_todos();
        }

        private void TxtBuscarVencimientos_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscarVencimientos.Text != "Buscar producto/Codigo")
            {
                buscar_productos_vencidos();
                checkPorVencerEn30Dias.Checked = false;
                CheckProductosVencidos.Checked = false;
            }
        }

        private void buscar_productos_vencidos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_productos_vencidos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscarVencimientos.Text);

                da.Fill(dt);
                dataListadoVencimientos.DataSource = dt;
                con.Close();


                dataListadoVencimientos.Columns[0].Visible = false;
                dataListadoVencimientos.Columns[1].Visible = false;
                dataListadoVencimientos.Columns[6].Visible = false;
                dataListadoVencimientos.Columns[7].Visible = false;

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoInventarioReport);
                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
                styCabeceras.ForeColor = System.Drawing.Color.White;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataListadoVencimientos.ColumnHeadersDefaultCellStyle = styCabeceras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtBuscarVencimientos_Click(object sender, EventArgs e)
        {
            txtBuscarVencimientos.SelectAll();
        }

        private void CheckPorVencerEn30Dias_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_productos_vencidos_en_menos_de_30_dias();
            txtBuscarVencimientos.Text = "Buscar producto/Codigo";

        }
        private void mostrar_productos_vencidos_en_menos_de_30_dias()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_productos_vencidos_en_menos_de_30_dias", con);
              

                da.Fill(dt);
                dataListadoVencimientos.DataSource = dt;
                con.Close();


                dataListadoVencimientos.Columns[0].Visible = false;
                dataListadoVencimientos.Columns[1].Visible = false;
              

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoInventarioReport);
                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
                styCabeceras.ForeColor = System.Drawing.Color.White;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataListadoVencimientos.ColumnHeadersDefaultCellStyle = styCabeceras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckProductosVencidos_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_productos_vencidos();
            txtBuscarVencimientos.Text = "Buscar producto/Codigo";
        }

        private void mostrar_productos_vencidos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_productos_vencidos", con);


                da.Fill(dt);
                dataListadoVencimientos.DataSource = dt;
                con.Close();


                dataListadoVencimientos.Columns[0].Visible = false;
                dataListadoVencimientos.Columns[1].Visible = false;
                

                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dataListadoInventarioReport);
                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
                styCabeceras.ForeColor = System.Drawing.Color.White;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataListadoVencimientos.ColumnHeadersDefaultCellStyle = styCabeceras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void INVENTARIO_MENU_Load(object sender, EventArgs e)
        {
            pnlMovimentos.Dock = DockStyle.None;
            panelREPORTEInventario.Dock = DockStyle.None;
            panelINVENTARIObajo.Dock = DockStyle.None;
            panelVencimiento.Dock = DockStyle.None;
            pnlMovimentos.Visible = false;
            panelREPORTEInventario.Visible = false;
            panelINVENTARIObajo.Visible = false;
            panelVencimiento.Visible = false;
            panelKardex.Visible = true;
            panelKardex.Dock = DockStyle.Fill;
            panelBuscar.Visible = true;

            pnKardex.Visible = true;
            pnMovimientos.Visible = false;
            pnInventariosBajos.Visible = false;
            pnReporteDeInventarios.Visible = false;
            pnVencimientos.Visible = false;

            txtBuscarCardex_Movimientos.Text = "Buscar Producto";

            

        }

        private void BtnMovimentos_Click(object sender, EventArgs e)
        {
            pnlMovimentos.Dock = DockStyle.Fill;
            panelREPORTEInventario.Dock = DockStyle.None;
            panelINVENTARIObajo.Dock = DockStyle.None;
            panelVencimiento.Dock = DockStyle.None;
            pnlMovimentos.Visible = true;
            panel7.Visible = true;
            panelREPORTEInventario.Visible = false;
            panelINVENTARIObajo.Visible = false;
            panelVencimiento.Visible = false;
            panelKardex.Visible = false;
            panelKardex.Dock = DockStyle.None;

            pnKardex.Visible = false;
            pnMovimientos.Visible = true;
            pnInventariosBajos.Visible = false;
            pnReporteDeInventarios.Visible = false;
            pnVencimientos.Visible = false;

            

            
        }

        private void BtnKardex_Click(object sender, EventArgs e)
        {
            pnlMovimentos.Dock = DockStyle.None;
            panelREPORTEInventario.Dock = DockStyle.None;
            panelINVENTARIObajo.Dock = DockStyle.None;
            panelVencimiento.Dock = DockStyle.None;
            pnlMovimentos.Visible = false;
            panelREPORTEInventario.Visible = false;
            panelINVENTARIObajo.Visible = false;
            panelVencimiento.Visible = false;
            panelKardex.Visible = true;
            panelKardex.Dock = DockStyle.Fill;

            pnKardex.Visible = true;
            pnMovimientos.Visible = false;
            pnInventariosBajos.Visible = false;
            pnReporteDeInventarios.Visible = false;
            pnVencimientos.Visible = false;
        }

        private void BtnVencimentos_Click(object sender, EventArgs e)
        {
            pnlMovimentos.Dock = DockStyle.None;
            panelREPORTEInventario.Dock = DockStyle.None;
            panelINVENTARIObajo.Dock = DockStyle.None;
            panelVencimiento.Dock = DockStyle.Fill;
            pnlMovimentos.Visible = false;
            panelREPORTEInventario.Visible = false;
            panelINVENTARIObajo.Visible = false;
            panelVencimiento.Visible = true;
            panelKardex.Visible = false;
            panelKardex.Dock = DockStyle.None;

            pnKardex.Visible = false;
            pnMovimientos.Visible = false;
            pnInventariosBajos.Visible = false;
            pnReporteDeInventarios.Visible = false;
            pnVencimientos.Visible = true;
        }
    }
}
