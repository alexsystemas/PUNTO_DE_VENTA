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
using System.Management;

namespace PUNTO_DE_VENTA.MODULOS.PRODUCTOS_OK
{
    public partial class Productos_OK : Form
    {
        int txtcontador;
        public Productos_OK()
        {
            InitializeComponent();
        }
        public static int idUsuario;
        public static int idcaja;
     

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = true;
            PANELREGISTRO.Visible = true;
            PANELDEPARTAMENTO.Visible = true;
            CheckInventarios.Checked = true;
            panelInventario.Visible = true;
            panelGRUPOSELECT.Visible = true;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;

            mostrar_grupos();
            txtgrupo.Clear();


            lblEstadoCodigo.Text = "NUEVO";
            panelGRUPOSELECT.Visible = true;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            mostrar_grupos();
            txtgrupo.Clear();

            txtapartirde.Text = "0";
            txtStockHay.ReadOnly = false;
            TXTIDPRODUCTOOk.Text = "0";

            panelInventario.Visible = true;

            txtDescripcion.AutoCompleteCustomSource = CONEXION.DataHelper.LoadAutoComplete();
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;

            PANELDEPARTAMENTO.Visible = true;
            PorUnidad.Checked = true;
            No_aplica_fecha.Checked = false;


            txtDescripcion.Text = "";
            panelInventario.Visible = true;

            TGUARDAR.Visible = true;
            TGUARDARCAMBIOS.Visible = true;
        }
        private void MOSTRAR_CAJA_POR_SERIAL()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

            SqlCommand com = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Serial", lblSerialPc.Text);
            try
            {
                con.Open();
                idcaja = Convert.ToInt32(com.ExecuteScalar());
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mostrar_inicio_de_sesion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

            SqlCommand com = new SqlCommand("mostrar_inicio_De_sesion", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_serial_pc", lblSerialPc.Text);

            try
            {
                con.Open();
                idUsuario = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {


            }


        }
        private void Productos_OK_Load(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = false;
            PANELREGISTRO.Visible = false;
            panelInventario.Visible = false;
            panelGuardar.Visible = true;
            datalistado.Visible = true;
            mostrar_grupos();

            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");

            lblSerialPc.Text = MOS.Properties["SerialNumber"].Value.ToString();
            lblSerialPc.Text = lblSerialPc.Text.Trim();
            // MessageBox.Show("SERIAL" + lblSerialPc);

            mostrar_inicio_de_sesion();
            MOSTRAR_CAJA_POR_SERIAL();

        }
        private void mostrar_grupos()
        {
            panelGRUPOSELECT.Visible = true;
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_grupos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtgrupo.Text);
                da.Fill(dt);
                datalistadoGrupos.DataSource = dt;
                con.Close();

                datalistadoGrupos.DataSource = dt;
                datalistadoGrupos.Columns[2].Visible = false;
                datalistadoGrupos.Columns[3].Width = 500;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnGuardar_grupo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", txtgrupo.Text);
                cmd.Parameters.AddWithValue("@Por_defecto", "NO");
                cmd.ExecuteNonQuery();
                con.Close();
                mostrar_grupos();

                lblidGrupo.Text = datalistadoGrupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = datalistadoGrupos.SelectedCells[3].Value.ToString();

                panelGRUPOSELECT.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = false;
                btnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNuevoGrupo_Click(object sender, EventArgs e)
        {
            txtgrupo.Text = "Escribe el Nuevo Grupo";
            txtgrupo.SelectAll();
            txtgrupo.Focus();

            panelGRUPOSELECT.Visible = false;
            btnGuardar_grupo.Visible = true;
            BtnGuardarCambios.Visible = false;
            btnCancelar.Visible = true;
            btnNuevoGrupo.Visible = false;

        }

        private void Txtgrupo_TextChanged(object sender, EventArgs e)
        {
            mostrar_grupos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelGRUPOSELECT.Visible = false;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            txtgrupo.Clear();
            mostrar_grupos();
        }

        private void TGUARDAR_Click(object sender, EventArgs e)
        {
            double txtpreciomayoreoV = Convert.ToDouble(txtpreciomayoreo.Text);

            double txtapartirdeV = Convert.ToDouble(txtapartirde.Text);
            double txtcostoV = Convert.ToDouble(txtcosto.Text);
            double TXTPRECIODEVENTA2V = Convert.ToDouble(TXTPRECIODEVENTA2.Text);
            if (txtpreciomayoreo.Text == "") txtpreciomayoreo.Text = "0";
            if (txtapartirde.Text == "") txtapartirde.Text = "0";
            //TXTPRECIODEVENTA2.Text = TXTPRECIODEVENTA2.Text.Replace(lblmoneda.Text + " ", "");
            //TXTPRECIODEVENTA2.Text = System.String.Format(((decimal)TXTPRECIODEVENTA2.Text), "##0.00");
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtapartirde.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= TXTPRECIODEVENTA2V)
                {

                    DialogResult result;
                    result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        insertar_productos();
                    }
                    else
                    {
                        TXTPRECIODEVENTA2.Focus();
                    }


                }
                else if (txtcostoV < TXTPRECIODEVENTA2V)
                {
                    insertar_productos();
                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }
        private void insertar_productos()
        {
            if (txtpreciomayoreo.Text == "0" | txtpreciomayoreo.Text == "") txtapartirde.Text = "0";

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Producto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Imagen", ".");
                cmd.Parameters.AddWithValue("@Precio_de_compra", txtcosto.Text);
                cmd.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA2.Text);
                cmd.Parameters.AddWithValue("@Codigo", txtcodigodebarra.Text);
                cmd.Parameters.AddWithValue("@A_partir_de", txtapartirde.Text);
                cmd.Parameters.AddWithValue("@Impuesto", 0);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text);
                if (PorUnidad.Checked == true) txtse_vende_a.Text = "Unidad";
                if (Agranel.Checked == true) txtse_vende_a.Text = "Granel";

                cmd.Parameters.AddWithValue("@Se_vende_a", txtse_vende_a.Text);
                cmd.Parameters.AddWithValue("@Id_grupo", lblidGrupo.Text);
                if (panelInventario.Visible == true)
                {
                    cmd.Parameters.AddWithValue("@Usa_inventarios", "SI");
                    cmd.Parameters.AddWithValue("@Stock_minimo", txtStockMinimo.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStockHay.Text);

                    if (No_aplica_fecha.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    }

                    if (No_aplica_fecha.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text);
                    }


                }
                if (panelInventario.Visible == false)
                {
                    cmd.Parameters.AddWithValue("@Usa_inventarios", "NO");
                    cmd.Parameters.AddWithValue("@Stock_minimo", 0);
                    cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    cmd.Parameters.AddWithValue("@Stock", "Ilimitado");

                }
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);
                cmd.Parameters.AddWithValue("@Motivo", "Registro inicial de Producto");
                cmd.Parameters.AddWithValue("@Cantidad ", txtStockHay.Text);
                cmd.Parameters.AddWithValue("@Id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@Tipo", "ENTRADA");
                cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO");
                cmd.Parameters.AddWithValue("@Id_caja", idcaja);

                cmd.ExecuteNonQuery();


                con.Close();
                pnlPrincipal.Visible = false;
                txtbusca.Text = txtDescripcion.Text;
                buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DatalistadoGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoGrupos.Columns["EliminarG"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este Grupo?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistadoGrupos.SelectedRows)
                        {

                            int onekey = Convert.ToInt32(row.Cells["Idline"].Value);

                            try
                            {

                                try
                                {

                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_grupos", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@id", onekey);
                                    cmd.ExecuteNonQuery();

                                    con.Close();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                        }
                        txtgrupo.Text = "GENERAL";
                        mostrar_grupos();
                        lblidGrupo.Text = datalistadoGrupos.SelectedCells[2].Value.ToString();
                        panelGRUPOSELECT.Visible = true;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (e.ColumnIndex == this.datalistadoGrupos.Columns["EditarG"].Index)

            {
                lblidGrupo.Text = datalistadoGrupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = datalistadoGrupos.SelectedCells[3].Value.ToString();
                panelGRUPOSELECT.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = false;
                btnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;
            }
            if (e.ColumnIndex == this.datalistadoGrupos.Columns["Grupo"].Index)
            {
                lblidGrupo.Text = datalistadoGrupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = datalistadoGrupos.SelectedCells[3].Value.ToString();
                panelGRUPOSELECT.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = false;
                btnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;

                if (lblEstadoCodigo.Text == "NUEVO")
                {
                    GENERAR_CODIGO_DE_BARRAS_AUTOMATICO();
                }

            }

        }
        private void GENERAR_CODIGO_DE_BARRAS_AUTOMATICO()
        {
            Double resultado;
            string queryMoneda;
            queryMoneda = "SELECT max(Id_Producto1)  FROM Producto1";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            try
            {
                con.Open();
                resultado = Convert.ToDouble(comMoneda.ExecuteScalar()) + 1;
                con.Close();
            }
            catch (Exception ex)
            {
                resultado = 1;
            }

            string Cadena = txtgrupo.Text;
            string[] Palabra;
            String espacio = " ";
            Palabra = Cadena.Split(Convert.ToChar(espacio));
            try
            {

                txtcodigodebarra.Text = resultado + Palabra[0].Substring(0, 2) + 369;
            }
            catch (Exception ex)
            {
            }
        }
        private void mostrar_descripcion_produco_sin_repetir()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_descripcion_produco_sin_repetir", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtDescripcion.Text);
                da.Fill(dt);
                DATALISTADO_PRODUCTOS_OKA.DataSource = dt;
                con.Close();

                datalistado.Columns[1].Width = 500;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
        private void contar()
        {
            int x;

            x = DATALISTADO_PRODUCTOS_OKA.Rows.Count;
            txtcontador = (x);

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            mostrar_descripcion_produco_sin_repetir();
            contar();

            if (txtcontador == 0)
            {
                DATALISTADO_PRODUCTOS_OKA.Visible = false;
            }
            if (txtcontador > 0)
            {
                DATALISTADO_PRODUCTOS_OKA.Visible = true;
            }
            if (TGUARDAR.Visible == false)
            {
                DATALISTADO_PRODUCTOS_OKA.Visible = false;
            }
        }

        private void DATALISTADO_PRODUCTOS_OKA_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtDescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[1].Value.ToString();
                DATALISTADO_PRODUCTOS_OKA.Visible = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void TimerCalucular_porcentaje_ganancia_Tick(object sender, EventArgs e)
        {

            TimerCalucular_porcentaje_ganancia.Stop();
            try
            {


                double TotalVentaVariabledouble;
                double TXTPRECIODEVENTA2V = Convert.ToDouble(TXTPRECIODEVENTA2.Text);
                double txtcostov = Convert.ToDouble(txtcosto.Text);

                TotalVentaVariabledouble = ((TXTPRECIODEVENTA2V - txtcostov) / (txtcostov)) * 100;

                if (TotalVentaVariabledouble > 0)
                {
                    this.txtPorcentajeGanancia.Text = Convert.ToString(TotalVentaVariabledouble);
                }
                else
                {
                    //Me.txtPorcentajeGanancia.Text = 0
                }


            }
            catch (Exception ex)
            {

            }
        }
        internal void proceso_para_obtener_datos_de_productos()
        {
            try
            {

                datalistado.Visible = false;
                pnlPrincipal.Visible = true;
                PANELREGISTRO.Visible = true;
                panelInventario.Visible = true;
                panelGuardar.Visible = true;


                TGUARDAR.Visible = false;
                TGUARDARCAMBIOS.Visible = true;
                PANELDEPARTAMENTO.Visible = true;


                btnNuevoGrupo.Visible = true;
                TXTIDPRODUCTOOk.Text = datalistado.SelectedCells[2].Value.ToString();
                lblEstadoCodigo.Text = "EDITAR";
                panelGRUPOSELECT.Visible = false;
                BtnGuardarCambios.Visible = false;
                btnGuardar_grupo.Visible = false;
                btnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                TXTIDPRODUCTOOk.Text = datalistado.SelectedCells[2].Value.ToString();
                txtcodigodebarra.Text = datalistado.SelectedCells[3].Value.ToString();
                txtgrupo.Text = datalistado.SelectedCells[4].Value.ToString();

                txtDescripcion.Text = datalistado.SelectedCells[5].Value.ToString();
                txtnumeroigv.Text = datalistado.SelectedCells[6].Value.ToString();
                lblidGrupo.Text = datalistado.SelectedCells[15].Value.ToString();


                LBL_ESSERVICIO.Text = datalistado.SelectedCells[7].Value.ToString();



                txtcosto.Text = datalistado.SelectedCells[8].Value.ToString();
                txtpreciomayoreo.Text = datalistado.SelectedCells[9].Value.ToString();
                LBLSEVENDEPOR.Text = datalistado.SelectedCells[10].Value.ToString();
                if (LBLSEVENDEPOR.Text == "Unidad")
                {
                    PorUnidad.Checked = true;

                }
                if (LBLSEVENDEPOR.Text == "Granel")
                {
                    Agranel.Checked = true;
                }
                txtStockMinimo.Text = datalistado.SelectedCells[11].Value.ToString();
                lblfechasvenci.Text = datalistado.SelectedCells[12].Value.ToString();
                if (lblfechasvenci.Text == "NO APLICA")
                {
                    No_aplica_fecha.Checked = true;
                }
                if (lblfechasvenci.Text != "NO APLICA")
                {
                    No_aplica_fecha.Checked = false;
                }
                txtStockHay.Text = datalistado.SelectedCells[13].Value.ToString();
                TXTPRECIODEVENTA2.Text = datalistado.SelectedCells[14].Value.ToString();
                try
                {

                    double TotalVentaVariabledouble;
                    double TXTPRECIODEVENTA2V = Convert.ToDouble(TXTPRECIODEVENTA2.Text);
                    double txtcostov = Convert.ToDouble(txtcosto.Text);

                    TotalVentaVariabledouble = ((TXTPRECIODEVENTA2V - txtcostov) / (txtcostov)) * 100;

                    if (TotalVentaVariabledouble > 0)
                    {
                        this.txtPorcentajeGanancia.Text = Convert.ToString(TotalVentaVariabledouble);
                    }
                    else
                    {
                        //Me.txtPorcentajeGanancia.Text = 0
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                if (LBL_ESSERVICIO.Text == "SI")
                {

                    panelInventario.Visible = true;
                    panelInventario.Visible = true;
                    txtStockHay.ReadOnly = true;
                    CheckInventarios.Checked = true;

                }
                if (LBL_ESSERVICIO.Text == "NO")
                {
                    CheckInventarios.Checked = false;

                    panelInventario.Visible = false;
                    panelInventario.Visible = false;
                    txtStockHay.ReadOnly = true;
                    txtStockHay.Text = "0";
                    txtStockMinimo.Text = "0";
                    No_aplica_fecha.Checked = true;
                    txtStockHay.ReadOnly = false;
                }
                txtapartirde.Text = datalistado.SelectedCells[16].Value.ToString();


                panelGRUPOSELECT.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TGUARDARCAMBIOS_Click(object sender, EventArgs e)
        {
            double txtpreciomayoreoV = Convert.ToDouble(txtpreciomayoreo.Text);

            double txtapartirdeV = Convert.ToDouble(txtapartirde.Text);
            double txtcostoV = Convert.ToDouble(txtcosto.Text);
            double TXTPRECIODEVENTA2V = Convert.ToDouble(TXTPRECIODEVENTA2.Text);
            if (txtpreciomayoreo.Text == "") txtpreciomayoreo.Text = "0";
            if (txtapartirde.Text == "") txtapartirde.Text = "0";
            //TXTPRECIODEVENTA2.Text = TXTPRECIODEVENTA2.Text.Replace(lblmoneda.Text + " ", "");
            //TXTPRECIODEVENTA2.Text = System.String.Format(((decimal)TXTPRECIODEVENTA2.Text), "##0.00");
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtapartirde.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= TXTPRECIODEVENTA2V)
                {

                    DialogResult result;
                    result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        editar_productos();
                    }
                    else
                    {
                        TXTPRECIODEVENTA2.Focus();
                    }


                }
                else if (txtcostoV < TXTPRECIODEVENTA2V)
                {
                    editar_productos();
                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            datalistado.Visible = true;
            PANELDEPARTAMENTO.Visible = true;
            pnlPrincipal.Visible = false;
            PANELREGISTRO.Visible = false;
            panelGuardar.Visible = false;
        }

        private void editar_productos()
        {
            if (txtpreciomayoreo.Text == "0" | txtpreciomayoreo.Text == "") txtapartirde.Text = "0";

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_Producto1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Producto1", TXTIDPRODUCTOOk.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Imagen", ".");

                cmd.Parameters.AddWithValue("@Precio_de_compra", txtcosto.Text);
                cmd.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA2.Text);
                cmd.Parameters.AddWithValue("@Codigo", txtcodigodebarra.Text);
                cmd.Parameters.AddWithValue("@A_partir_de", txtapartirde.Text);
                cmd.Parameters.AddWithValue("@Impuesto", 0);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text);
                if (PorUnidad.Checked == true) txtse_vende_a.Text = "Unidad";
                if (Agranel.Checked == true) txtse_vende_a.Text = "Granel";

                cmd.Parameters.AddWithValue("@Se_vende_a", txtse_vende_a.Text);
                cmd.Parameters.AddWithValue("@Id_grupo", lblidGrupo.Text);
                if (panelInventario.Visible == true)
                {
                    cmd.Parameters.AddWithValue("@Usa_inventarios", "SI");
                    cmd.Parameters.AddWithValue("@Stock_minimo", txtStockMinimo.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStockHay.Text);

                    if (No_aplica_fecha.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    }

                    if (No_aplica_fecha.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text);
                    }


                }
                if (panelInventario.Visible == false)
                {
                    cmd.Parameters.AddWithValue("@Usa_inventarios", "NO");
                    cmd.Parameters.AddWithValue("@Stock_minimo", 0);
                    cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    cmd.Parameters.AddWithValue("@Stock", "Ilimitado");

                }

                cmd.ExecuteNonQuery();


                con.Close();
                PANELDEPARTAMENTO.Visible = false;
                txtbusca.Text = txtDescripcion.Text;
                buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buscar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_producto_por_descripcion", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbusca.Text);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();

                datalistado.Columns[2].Visible = false;
                datalistado.Columns[7].Visible = false;
                datalistado.Columns[10].Visible = false;
                datalistado.Columns[15].Visible = false;
                datalistado.Columns[16].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);
            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
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
                lblcosto_inventario.Text = resultado + " " + importe;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                lblcosto_inventario.Text = resultado + " " + 0;
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
                lblcantidad_productos.Text = conteoresultado;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                conteoresultado = "";
                lblcantidad_productos.Text = "0";
            }

        }

        private void GenerarCodigo_Click(object sender, EventArgs e)
        {
            GENERAR_CODIGO_DE_BARRAS_AUTOMATICO();
        }

        private void TxtPorcentajeGanancia_TextChanged(object sender, EventArgs e)
        {
            TimerCalucular_porcentaje_ganancia.Stop();

            timerCalcula_Precio_de_Venta.Start();
            TimerCalucular_porcentaje_ganancia.Stop();
        }

        private void TimerCalcula_Precio_de_Venta_Tick(object sender, EventArgs e)
        {
            timerCalcula_Precio_de_Venta.Stop();

            try
            {
                double TotalVentaVariabledouble;
                double txtcostov = Convert.ToDouble(txtcosto.Text);
                double txtPorcentajeGananciav = Convert.ToDouble(txtPorcentajeGanancia.Text);

                TotalVentaVariabledouble = txtcostov + ((txtcostov * txtPorcentajeGananciav) / 100);

                if (TotalVentaVariabledouble > 0 & txtPorcentajeGanancia.Focused == true)
                {
                    this.TXTPRECIODEVENTA2.Text = Convert.ToString(TotalVentaVariabledouble);
                }
                else
                {
                    //Me.txtPorcentajeGanancia.Text = 0
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CheckInventarios_CheckedChanged(object sender, EventArgs e)
        {


            if (TXTIDPRODUCTOOk.Text != "0" & Convert.ToDouble(txtStockHay.Text) > 0)
            {
                if (CheckInventarios.Checked == false)
                {
                    MessageBox.Show("Hay Aun En Stock, Dirijete al Modulo Inventarios para Ajustar el Inventario a cero", "Stock Existente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    panelInventario.Visible = true;
                    CheckInventarios.Checked = true;
                }
            }

            if (TXTIDPRODUCTOOk.Text != "0" & Convert.ToDouble(txtStockHay.Text) == 0)
            {
                if (CheckInventarios.Checked == false)
                {
                    panelInventario.Visible = false;

                }
            }

            if (TXTIDPRODUCTOOk.Text == "0")
            {
                if (CheckInventarios.Checked == false)
                {
                    panelInventario.Visible = false;

                }
            }

            if (CheckInventarios.Checked == true)
            {

                panelInventario.Visible = true;
            }
        }

        private void Datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este Producto?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistado.SelectedRows)
                        {

                            int onekey = Convert.ToInt32(row.Cells["Id_Producto1"].Value);

                            try
                            {

                                try
                                {

                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_Producto1", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@id", onekey);
                                    cmd.ExecuteNonQuery();

                                    con.Close();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                        }
                        buscar();
                    }

                    catch (Exception ex)
                    {

                    }



                }



            }
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                proceso_para_obtener_datos_de_productos();
            }
        }

        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = false;
            PANELREGISTRO.Visible = false;
            datalistado.Visible = true;
        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            Dispose();
            MODULOS.CONFIGURACION.PANEL_CONFIGURACIONES frm = new MODULOS.CONFIGURACION.PANEL_CONFIGURACIONES();
            frm.ShowDialog();
        }

        private void Datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            proceso_para_obtener_datos_de_productos();
        }

        private void BtnRegresar_DoubleClick(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = false;
            PANELREGISTRO.Visible = false;
            datalistado.Visible = true;
        }

        private void Txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') || (e.KeyChar != ','))
            {


                string CultureName = Thread.CurrentThread.CurrentCulture.Name;
                CultureInfo ci = new CultureInfo(CultureName);


                ci.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = ci;

            }
            Separador_de_Numeros(txtcosto, e);
        }
        public static void Separador_de_Numeros(System.Windows.Forms.TextBox CajaTexto, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (!(e.KeyChar == CajaTexto.Text.IndexOf('.')))
            {
                e.Handled = true;
            }


            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }

        }

        private void BtnImportarExcel_Click(object sender, EventArgs e)
        {
            MODULOS.PRODUCTOS_OK.Asistente_de_ImportacionExcel frm = new MODULOS.PRODUCTOS_OK.Asistente_de_ImportacionExcel();
            frm.ShowDialog();
        }
    }
}
