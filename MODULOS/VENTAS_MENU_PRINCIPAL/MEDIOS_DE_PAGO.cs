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
using System.Drawing.Printing;
namespace PUNTO_DE_VENTA.MODULOS.VENTAS_MENU_PRINCIPAL
{
    public partial class MEDIOS_DE_PAGO : Form
    {
        public MEDIOS_DE_PAGO()
        {
            InitializeComponent();
        }
        string moneda;
        int idcliente;
        public static int idventa;
        double total;
        double vuelto = 0;
        double efectivo_calculado = 0;
        double restante = 0;
        double credito = 0;
        int INDICADOR_DE_FOCO;
        bool SECUENCIA1 = true;
        bool SECUENCIA2 = true;
        bool SECUENCIA3 = true;

        private void MEDIOS_DE_PAGO_Load(object sender, EventArgs e)
        {
            cambiar_el_formato_de_separador_de_decimales();
            MOSTRAR_comprobante_serializado_POR_DEFECTO();
            obtener_serial_pc();
            mostrar_moneda_de_empresa();
            configuraciones_de_diseño();
            Obtener_id_de_venta();
            mostrar_impresora();
            cargar_impresoras_del_equipo();
            calcular_restante();
        }
        void calcular_restante()
        {
            try
            {
                double efectivo = 0;
                double tarjeta = 0;

                if (txtefectivo2.Text == "")
                {
                    efectivo = 0;
                }
                else
                {
                    efectivo = Convert.ToDouble(txtefectivo2.Text);
                }
                if (txtcredito2.Text == "")
                {
                    credito = 0;
                }
                else
                {
                    credito = Convert.ToDouble(txtcredito2.Text);
                }
                if (txttarjeta2.Text == "")
                {
                    tarjeta = 0;
                }
                else
                {
                    tarjeta = Convert.ToDouble(txttarjeta2.Text);
                }

                if (txtefectivo2.Text == "0.00")
                {
                    efectivo = 0;
                }
                if (txtcredito2.Text == "0.00")
                {
                    credito = 0;
                }
                if (txttarjeta2.Text == "0.00")
                {
                    tarjeta = 0;

                }

                if (txtefectivo2.Text == ".")
                {
                    efectivo = 0;
                }
                if (txtcredito2.Text == ".")
                {
                    tarjeta = 0;
                }
                if (txttarjeta2.Text == ".")
                {
                    credito = 0;
                }
                ///////
                //Total= 5 
                //Efectivo= 10
                // Tarjeta = 22
                //EC=E-(T+TA)
                //EC= 10-(5+22)
                //EC= 3
                //V=E-(T-TA)
                //V=10-(5-2)
                //V=7

                try
                {
                    if (efectivo > total)
                    {
                        efectivo_calculado = efectivo - (total + credito + tarjeta);
                        if (efectivo_calculado < 0)
                        {
                            vuelto = 0;
                            TXTVUELTO.Text = "0";
                            txtrestante.Text = Convert.ToString(efectivo_calculado);
                            restante = efectivo_calculado;
                        }
                        else
                        {
                            vuelto = efectivo - (total - credito - tarjeta);
                            TXTVUELTO.Text = Convert.ToString(vuelto);
                            restante = efectivo - (total + credito + tarjeta + efectivo_calculado);
                            txtrestante.Text = Convert.ToString(restante);
                            txtrestante.Text = decimal.Parse(txtrestante.Text).ToString("##0.00");
                        }

                    }
                    else
                    {
                        vuelto = 0;
                        TXTVUELTO.Text = "0";
                        efectivo_calculado = efectivo;
                        restante = total - efectivo_calculado - credito - tarjeta;
                        txtrestante.Text = Convert.ToString(restante);
                        txtrestante.Text = decimal.Parse(txtrestante.Text).ToString("##0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        void mostrar_impresora()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("mostrar_impresoras_por_caja", CONEXION.CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serial", lblSerialPC.Text);
                try
                {
                    CONEXION.CONEXIONMAESTRA.abrir();
                    txtImpresora.Text = Convert.ToString(cmd.ExecuteScalar());
                    CONEXION.CONEXIONMAESTRA.cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        void cargar_impresoras_del_equipo()
        {
            txtImpresora.Items.Clear();
            for (var I = 0; I < PrinterSettings.InstalledPrinters.Count; I++)
            {
                txtImpresora.Items.Add(PrinterSettings.InstalledPrinters[I]);
            }
            txtImpresora.Items.Add("Ninguna");
        }
        void Obtener_id_de_venta()
        {
            idventa = VENTAS_MENU_PRINCIPALOK.idVenta;
        }
        void configuraciones_de_diseño()
        {
           // btnGuradarImprimirDirecto.Text = " Guadar e Imprimir " + lblComprobante + "(Enter)";
            TXTVUELTO.Text = "0.0";
            txtrestante.Text = "0.0";
            TXTTOTAL.Text = moneda + " " + VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK.total;
            total = VENTAS_MENU_PRINCIPALOK.total;
            idcliente = 0;

        }
        void mostrar_moneda_de_empresa()
        {
            SqlCommand cmd = new SqlCommand("Select Moneda From Empresa", CONEXION.CONEXIONMAESTRA.conectar);
            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                moneda = Convert.ToString(cmd.ExecuteScalar());
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public void obtener_serial_pc()
        {
            CONEXION.Obtener_serial_de_PC.ObtenerSerialPC(ref lblSerialPC);
        }
        public void cambiar_el_formato_de_separador_de_decimales()
        {
            CONEXION.cambiar_el_formato_de_seprador_de_decimales.cambiar();
        }
        private void MOSTRAR_comprobante_serializado_POR_DEFECTO()
        {
            SqlCommand cmd = new SqlCommand("select tipodoc from Serializacion Where Por_defecto='SI'", CONEXION.CONEXIONMAESTRA.conectar);
            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                lblComprobante.Text = Convert.ToString(cmd.ExecuteScalar());
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dibujarCOMPROBANTES();
        }

        private void dibujarCOMPROBANTES()
        {
            flowLayoutPanel6.Controls.Clear();
           // flowLayoutPanel6.Controls.Clear();
            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                string query = "select tipodoc from Serializacion where Destino='VENTAS'";
                SqlCommand cmd = new SqlCommand(query, CONEXION.CONEXIONMAESTRA.conectar);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Button b = new Button();
                    b.Visible = true;
                    b.Text = rdr["tipodoc"].ToString();
                    b.Size = new System.Drawing.Size(191, 60);
                    b.BackColor = Color.FromArgb(70, 70, 71);
                    b.Font = new System.Drawing.Font("Segoe UI", 13);
                    b.FlatStyle = FlatStyle.Flat;
                    b.ForeColor = Color.WhiteSmoke;
                    flowLayoutPanel6.Controls.Add(b);
                    if (b.Text == lblComprobante.Text)
                    {
                        b.Visible = false;
                    }
                    b.Click += miEvento;
                }
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void miEvento(System.Object sender, EventArgs e)
        {
            lblComprobante.Text = ((Button)sender).Text;
            dibujarCOMPROBANTES();
            //validar_tipos_de_comprobantes();
            //identificar_el_tipo_de_pago();
            //if (lblComprobante.Text == "FACTURA" && txttipo == "CREDITO")
            //{
            //    PANEL_CLIENTE_FACTURA.Visible = false;
            //}
            //if (lblComprobante.Text == "FACTURA" && txttipo == "EFECTIVO")
            //{
            //    PANEL_CLIENTE_FACTURA.Visible = true;
            //    lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)";
            //    lblindicador_de_factura_1.ForeColor = Color.FromArgb(255, 192, 192);

            //}
            //else if (lblComprobante.Text != "FACTURA" && txttipo == "EFECTIVO")
            //{
            //    PANEL_CLIENTE_FACTURA.Visible = true;
            //    lblindicador_de_factura_1.Text = "Cliente: (Opcional)";
            //    lblindicador_de_factura_1.ForeColor = Color.DimGray;

            //}

            //if (lblComprobante.Text == "FACTURA" && txttipo == "TARJETA")
            //{
            //    PANEL_CLIENTE_FACTURA.Visible = true;
            //    lblindicador_de_factura_1.Text = "Cliente: (Obligatorio)";
            //    lblindicador_de_factura_1.ForeColor = Color.FromArgb(255, 192, 192);

            //}
            //else if (lblComprobante.Text != "FACTURA" && txttipo == "TARJETA")
            //{
            //    PANEL_CLIENTE_FACTURA.Visible = true;
            //    lblindicador_de_factura_1.Text = "Cliente: (Opcional)";
            //    lblindicador_de_factura_1.ForeColor = Color.DimGray;
            //}


        }

        private void Txtefectivo2_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }

        private void Txttarjeta2_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }

        private void Txtcredito2_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
            hacer_visible_panel_de_cliente_a_credito();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "1";
            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "1";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "2";
            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "2";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "3";
            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "3";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "4";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "4";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "5";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "5";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "6";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "6";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "7";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "7";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "8";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "8";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "9";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "9";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Text = txtefectivo2.Text + "0";

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Text = txttarjeta2.Text + "0";
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Text = txtcredito2.Text + "0";
            }
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                if (SECUENCIA1 == true)
                {
                    txtefectivo2.Text = txtefectivo2.Text + ".";
                    SECUENCIA1 = false;
                }

                else
                {
                    return;
                }

            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                if (SECUENCIA2 == true)
                {
                    txttarjeta2.Text = txttarjeta2.Text + ".";
                    SECUENCIA2 = false;
                }

                else
                {
                    return;
                }

            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                if (SECUENCIA3 == true)
                {
                    txtcredito2.Text = txtcredito2.Text + ".";
                    SECUENCIA3 = false;
                }

                else
                {
                    return;
                }

            }

        }

        private void Btnborrartodo_Click(object sender, EventArgs e)
        {
            if (INDICADOR_DE_FOCO == 1)
            {
                txtefectivo2.Clear();
                SECUENCIA1 = true;
            }
            else if (INDICADOR_DE_FOCO == 2)
            {
                txttarjeta2.Clear();
                SECUENCIA2 = true;
            }
            else if (INDICADOR_DE_FOCO == 3)
            {
                txtcredito2.Clear();
                SECUENCIA3 = true;
            }
        }

        private void Txtclientesolicitabnte2_TextChanged(object sender, EventArgs e)
        {
            buscarclientes2();
            datalistadoclientes2.Visible = true;
        }

        void buscarclientes2()
        {
            DataTable dt = new DataTable();

            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscar_cliente_POR_nombre_PARA_VENTAS_todos", CONEXION.CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtclientesolicitabnte2.Text);
                da.Fill(dt);
                datalistadoclientes2.DataSource = dt;
                datalistadoclientes2.Columns[2].Visible = false;
                datalistadoclientes2.Columns[3].Visible = false;
                datalistadoclientes2.Columns[4].Visible = false;
                datalistadoclientes2.Columns[5].Visible = false;
                datalistadoclientes2.Columns[1].Width = 420;
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

            }
        }

        private void Datalistadoclientes2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtclientesolicitabnte2.Text = datalistadoclientes2.SelectedCells[1].Value.ToString();
            idcliente = Convert.ToInt32(datalistadoclientes2.SelectedCells[2].Value.ToString());
            datalistadoclientes2.Visible = false;
        }

        void hacer_visible_panel_de_cliente_a_credito()
        {
            try
            {
                double textocredito = 0;
                if(txtcredito2.Text ==".")
                {
                    textocredito = 0;
                }
                if(txtcredito2.Text=="")
                {
                    textocredito = 0;
                }
                else
                {
                    textocredito = Convert.ToDouble(txtcredito2.Text);
                }
                if(textocredito>0)
                {
                    pcredito.Visible = true;
                }
                else
                {
                    pcredito.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            insertar_cliente();
            PANELREGISTRO.Visible = false;
        }
        void insertar_cliente()
        {
            if (txtnombrecliente.Text != "")
            {

                if (txtdirecciondefactura.Text == "")
                {
                    txtdirecciondefactura.Text = "0";
                }
                if (txtrucdefactura.Text == "")
                {
                    txtrucdefactura.Text = "0";
                }
                if (txtcelular.Text == "")
                {
                    txtcelular.Text = "0";
                }


                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtnombrecliente.Text);
                    cmd.Parameters.AddWithValue("@Direccion_para_factura", txtdirecciondefactura.Text);
                    cmd.Parameters.AddWithValue("@RFC", txtrucdefactura.Text);
                    cmd.Parameters.AddWithValue("@movil", txtcelular.Text);
                    cmd.Parameters.AddWithValue("@Cliente", "SI");
                    cmd.Parameters.AddWithValue("@Proveedor", "NO");
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                    cmd.Parameters.AddWithValue("@Saldo", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = false;
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = true;
            PANELREGISTRO.Dock = DockStyle.Fill;
            PANELREGISTRO.BringToFront();
            limpiar_datos_de_registrodeclientes();
        }

        void limpiar_datos_de_registrodeclientes()
        {
            txtnombrecliente.Clear();
            txtdirecciondefactura.Clear();
            txtcelular.Clear();
            txtrucdefactura.Clear();
        }

        private void Txtefectivo2_Click(object sender, EventArgs e)
        {
            calcular_restante();
            INDICADOR_DE_FOCO = 1;
            if(txtrestante.Text=="0.00")
            {
                txtefectivo2.Text = "";
            }
            else
            {
                txtefectivo2.Text = txtrestante.Text;
            }
        }

        private void Txttarjeta2_Click(object sender, EventArgs e)
        {
            calcular_restante();
            INDICADOR_DE_FOCO = 2;
            if (txtrestante.Text == "0.00")
            {
                txttarjeta2.Text = "";
            }
            else
            {
                txttarjeta2.Text = txtrestante.Text;
            }
        }

        private void Txtcredito2_Click(object sender, EventArgs e)
        {
            calcular_restante();
            INDICADOR_DE_FOCO = 3;
            if (txtrestante.Text == "0.00")
            {
                txtcredito2.Text = "";
            }
            else
            {
                txtcredito2.Text = txtrestante.Text;
                hacer_visible_panel_de_cliente_a_credito();

            }
        }
    }
}

