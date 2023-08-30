using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.PRESENT.VENTAS_MENU_PRINCIPAL;
using PUNTO_DE_VENTA.DATE;

namespace PUNTO_DE_VENTA.PRESENT.VENTAS_MENU_PRINCIPAL
{
    public partial class VENTAS_MENU_PRINCIPALOK : Form
    {
        public VENTAS_MENU_PRINCIPALOK()
        {
            InitializeComponent();
        }
        int Contador_stock_detalle_de_venta;
        int idProducto;
        int idClienteEstandar;
        int iddetalleventa;
        public static int idusuario_que_inicio_sesion;
        public static  int idVenta;
        int idproducto;
        int contador;
        public static double txtpantalla;
        double lblStock_De_Productos;
        public static double total;
        public static int Id_caja;
        string SerialPC;
        string sevendePor;
        string txtVentaGenerada;
        double txtPrecio_Unitario;
        string usaInventarios;
        Panel panel_mostrador_de_productos = new Panel();

        private void VENTAS_MENU_PRINCIPALOK_Load(object sender, EventArgs e)
        {
            Bases.Cambiar_idioma_regional();
            Bases.Obtener_serialPC(ref SerialPC);
            // CONEXION.Obtener_serial_de_PC.ObtenerSerialPC(ref lblSerialPc);

            Obtener_datos.obtener_id_caja_PorSerial(ref Id_caja);
           
            MOSTRAR_TIPO_DE_BUSQUEDA();
            Obtener_id_de_cliente_estandar();
            Obtener_id_de_usuario_que_inicio_sesion();

            if (Tipo_de_busqueda == "TECLADO")
            {
                lbltipodebusqueda2.Text = "Buscar con TECLADO";
                btn_Scanner.BackColor = Color.WhiteSmoke;
                btn_Teclado.BackColor = Color.LightGreen;
            }
            else
            {
                lbltipodebusqueda2.Text = "Buscar con LECTORA de Codigos de Barras";
                btn_Scanner.BackColor = Color.LightGreen;
                btn_Teclado.BackColor = Color.WhiteSmoke;
            }
            Limpiar_para_venta_nueva();
        }

        private void Limpiar_para_venta_nueva()
        {
            idVenta = 0;
            Listarproductosagregados();
            txtVentaGenerada = "VENTA NUEVA";
            sumar();
            pnlEnEspera.Visible = false;
        }
        private void sumar()
        {
            try
            {

                int x;
                x = datalistadoDetalleVenta.Rows.Count;
                if (x == 0)
                {
                    txt_total_suma.Text = "0.00";
                }

                double totalpagar;
                totalpagar = 0;
                foreach (DataGridViewRow fila in datalistadoDetalleVenta.Rows)
                {

                    totalpagar += Convert.ToDouble(fila.Cells["Importe"].Value);
                    txt_total_suma.Text = Convert.ToString(totalpagar);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void LISTAR_PRODUCTOS_Abuscador()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                CONEXION.CONEXIONMAESTRA.abrir();
                da = new SqlDataAdapter("BUSCAR_PRODUCTOS_oka", CONEXION.CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letrab", txtbuscar.Text);
                da.Fill(dt);
                DATALISTADO_PRODUCTOS_OKA.DataSource = dt;
                CONEXION.CONEXIONMAESTRA.cerrar();
                DATALISTADO_PRODUCTOS_OKA.Columns[0].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[1].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[2].Width = 645;
                DATALISTADO_PRODUCTOS_OKA.Columns[3].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[4].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[5].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[6].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[7].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[8].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[9].Visible = false;
                DATALISTADO_PRODUCTOS_OKA.Columns[10].Visible = false;


            }
            catch (Exception ex)
            {
                CONEXION.CONEXIONMAESTRA.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
        }
        
      
        string Tipo_de_busqueda;
        private void MOSTRAR_TIPO_DE_BUSQUEDA()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand com = new SqlCommand("Select Modo_de_busqueda  from EMPRESA", con);

            try
            {
                con.Open();
                Tipo_de_busqueda = Convert.ToString(com.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            CAJA.CIERRE_DE_CAJA frm = new CAJA.CIERRE_DE_CAJA();
            frm.ShowDialog();
        }

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            PRESENT.PRODUCTOS_OK.Productos_OK frm = new PRESENT.PRODUCTOS_OK.Productos_OK();
            frm.ShowDialog();
        }

        private void BtnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            CAJA.CIERRE_DE_CAJA frm = new CAJA.CIERRE_DE_CAJA();
            frm.ShowDialog();
        }

        private void Txt_total_suma_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            Dispose();
            CONFIGURACION.PANEL_CONFIGURACIONES frm = new CONFIGURACION.PANEL_CONFIGURACIONES();
            frm.ShowDialog();
        }


        private void Btn_Teclado_Click(object sender, EventArgs e)
        {
            lbltipodebusqueda2.Text = "Buscar con  TECLADO";
            Tipo_de_busqueda = "TECLADO";
            btn_Teclado.BackColor = Color.LightGreen;
            btn_Scanner.BackColor = Color.WhiteSmoke;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }

        private void Btn_Scanner_Click(object sender, EventArgs e)
        {
            lbltipodebusqueda2.Text = "Buscar con LECTORA de Codigos de Barras";
            Tipo_de_busqueda = "LECTORA";
            btn_Scanner.BackColor = Color.LightGreen;
            btn_Teclado.BackColor = Color.WhiteSmoke;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (Tipo_de_busqueda == "LECTORA")
            {

                lbltipodebusqueda2.Visible = false;
                timerBUSCADORcodigodebarras.Start();
            }
            else if (Tipo_de_busqueda == "TECLADO")
            {
                if (txtbuscar.Text == "")
                {
                    ocultar_productos();
                }
                else if (txtbuscar.Text != "")
                {
                    mostrar_productos();
                }
                LISTAR_PRODUCTOS_Abuscador();

            }

        }
        private void mostrar_productos()
        {
            panel_mostrador_de_productos.Size = new System.Drawing.Size(600, 252);
            panel_mostrador_de_productos.BackColor = Color.White;
            panel_mostrador_de_productos.Location = new Point(panelReferencia.Location.X, panelReferencia.Location.Y);
            panel_mostrador_de_productos.Visible = true;
            DATALISTADO_PRODUCTOS_OKA.Visible = true;
            DATALISTADO_PRODUCTOS_OKA.Dock = DockStyle.Fill;
            lbltipodebusqueda2.Visible = false;
            panel_mostrador_de_productos.Controls.Add(DATALISTADO_PRODUCTOS_OKA);
            this.Controls.Add(panel_mostrador_de_productos);
            panel_mostrador_de_productos.BringToFront();


        }

        private void ocultar_productos()
        {
            panel_mostrador_de_productos.Visible = false;
            DATALISTADO_PRODUCTOS_OKA.Visible = false;
            lbltipodebusqueda2.Visible = true;
        }
        private void DATALISTADO_PRODUCTOS_OKA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DATALISTADO_PRODUCTOS_OKA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbuscar.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[10].Value.ToString();
            idproducto = Convert.ToInt32(DATALISTADO_PRODUCTOS_OKA.SelectedCells[1].Value.ToString());
            vender_por_teclado();

        }

        private void vender_por_teclado()
        {
            // mostramos los registros del producto en el detalle de venta
            mostrar_stock_de_detalle_de_ventas();
            contar_stock_detalle_ventas();

            if (Contador_stock_detalle_de_venta == 0)
            {
                // Si es producto no esta agregado a las ventas se tomara el Stock de la tabla Productos
                lblStock_De_Productos = Convert.ToDouble(DATALISTADO_PRODUCTOS_OKA.SelectedCells[4].Value.ToString());
            }
            else
            {
                //en caso que el producto ya este agregado al detalle de venta se va a extraer el Stock de la tabla Detalle_de_venta
                lblStock_De_Productos = Convert.ToDouble(datalistadoStockDetalleVenta2.SelectedCells[1].Value.ToString());
            }
            //Extraemos los datos del producto de la tabla Productos directamente
            usaInventarios = DATALISTADO_PRODUCTOS_OKA.SelectedCells[3].Value.ToString();
            lblDescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[9].Value.ToString();
            lblCodigo.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[10].Value.ToString();
            lblCosto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[5].Value.ToString();
            sevendePor = DATALISTADO_PRODUCTOS_OKA.SelectedCells[8].Value.ToString();
            txtPrecio_Unitario =Convert.ToDouble( DATALISTADO_PRODUCTOS_OKA.SelectedCells[6].Value.ToString());
            //Preguntamos que tipo de producto sera el que se agrege al detalle de venta
            if (sevendePor == "Granel")
            {
                vender_a_granel();
            }
            else if (sevendePor == "Unidad")
            {
                txtpantalla = 1;
                vender_por_unidad();
            }

        }
        private void vender_a_granel()
        {
            CANTIDAD_A_GRANEL frm = new CANTIDAD_A_GRANEL();
            frm.preciounitario= txtPrecio_Unitario;
            frm.FormClosing += Frm_FormClosing;
            frm.ShowDialog();
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ejecutar_ventas_a_granel();
        }

        public void ejecutar_ventas_a_granel()
        {
            ejecutar_insertar_ventas();
            if (txtVentaGenerada == "VENTA GENERADA")
            {
                insertar_detalle_venta();
                Listarproductosagregados();
                txtbuscar.Text = "";
                txtbuscar.Focus();

            }
        
    }
        private void Obtener_id_de_cliente_estandar()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand com = new SqlCommand("select idclientev  from clientes where Cliente='NEUTRO'", con);
            try
            {
                con.Open();
                idClienteEstandar = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void Obtener_id_de_usuario_que_inicio_sesion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand com = new SqlCommand("mostrar_inicio_De_sesion", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_serial_pc",Bases.Encriptar (SerialPC));
            try
            {
                con.Open();
                idusuario_que_inicio_sesion = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void Obtener_id_venta_recien_Creada()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand com = new SqlCommand("mostrar_id_venta_po_Id_caja", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id_caja", Id_caja);
            try
            {
                con.Open();
                idVenta = Convert.ToInt32(com.ExecuteScalar());
                MessageBox.Show("idVenta:" + idVenta);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("mostrar_id_venta_por_Id_caja");
            }
        }
        private void vender_por_unidad()
        {
            try
            {
                if (txtbuscar.Text == DATALISTADO_PRODUCTOS_OKA.SelectedCells[10].Value.ToString())
                {
                    DATALISTADO_PRODUCTOS_OKA.Visible = true;
                    ejecutar_insertar_ventas();
                    if (txtVentaGenerada == "VENTA GENERADA")
                    {
                        insertar_detalle_venta();
                        Listarproductosagregados();
                        txtbuscar.Text = "";
                        txtbuscar.Focus();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void ejecutar_insertar_ventas()
        {
            if (txtVentaGenerada == "VENTA NUEVA")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_venta", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcliente", idClienteEstandar);
                    cmd.Parameters.AddWithValue("@fecha_venta", DateTime.Today);
                    cmd.Parameters.AddWithValue("@nume_documento", 0);
                    cmd.Parameters.AddWithValue("@montototal", 0);
                    cmd.Parameters.AddWithValue("@Tipo_de_pago", 0);
                    cmd.Parameters.AddWithValue("@estado", "EN ESPERA");
                    cmd.Parameters.AddWithValue("@IGV", 0);
                    cmd.Parameters.AddWithValue("@Comprobante", 0);
                    cmd.Parameters.AddWithValue("@id_usuario", idusuario_que_inicio_sesion);
                    cmd.Parameters.AddWithValue("@Fecha_de_pago", DateTime.Today);
                    cmd.Parameters.AddWithValue("@ACCION", "VENTA");
                    cmd.Parameters.AddWithValue("@Saldo", 0);
                    cmd.Parameters.AddWithValue("@Pago_con", 0);
                    cmd.Parameters.AddWithValue("@Porcentaje_IGV", 0);
                    cmd.Parameters.AddWithValue("@Id_caja", Id_caja);
                    cmd.Parameters.AddWithValue("@Referencia_tarjeta", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Obtener_id_venta_recien_Creada();
                    txtVentaGenerada = "VENTA GENERADA";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }

            }
        }
        private void Listarproductosagregados()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_productos_agregados_a_venta", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idventa", idVenta);
                da.Fill(dt);
                datalistadoDetalleVenta.DataSource = dt;
                con.Close();
                datalistadoDetalleVenta.Columns[0].Width = 50;
                datalistadoDetalleVenta.Columns[1].Width = 50;
                datalistadoDetalleVenta.Columns[2].Width = 50;
                datalistadoDetalleVenta.Columns[3].Visible = false;
                datalistadoDetalleVenta.Columns[4].Width = 250;
                datalistadoDetalleVenta.Columns[5].Width = 100;
                datalistadoDetalleVenta.Columns[6].Width = 100;
                datalistadoDetalleVenta.Columns[7].Width = 100;
                datalistadoDetalleVenta.Columns[8].Visible = false;
                datalistadoDetalleVenta.Columns[9].Visible = false;
                datalistadoDetalleVenta.Columns[10].Visible = false;
                datalistadoDetalleVenta.Columns[11].Width = datalistadoDetalleVenta.Width - (datalistadoDetalleVenta.Columns[0].Width - datalistadoDetalleVenta.Columns[1].Width - datalistadoDetalleVenta.Columns[2].Width -
                  datalistadoDetalleVenta.Columns[4].Width - datalistadoDetalleVenta.Columns[5].Width - datalistadoDetalleVenta.Columns[6].Width - datalistadoDetalleVenta.Columns[7].Width);
                datalistadoDetalleVenta.Columns[12].Visible = false;
                datalistadoDetalleVenta.Columns[13].Visible = false;
                datalistadoDetalleVenta.Columns[14].Visible = false;
                datalistadoDetalleVenta.Columns[15].Visible = false;
                datalistadoDetalleVenta.Columns[16].Visible = false;
                datalistadoDetalleVenta.Columns[17].Visible = false;
                datalistadoDetalleVenta.Columns[18].Visible = false;
                sumar();
                Bases.Multilinea(ref datalistadoDetalleVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void insertar_detalle_venta()
        {
            try
            {
                if ( usaInventarios == "SI")
                {
                    if (lblStock_De_Productos >= txtpantalla)
                    {
                        insertar_detalle_venta_Validado();
                    }
                    else
                    {
                        timerLABEL_Stock.Start();
                    }
                }

                else if ( usaInventarios == "NO")
                {
                    insertar_detalle_venta_SIN_VALIDAR();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


        }
        private void insertar_detalle_venta_Validado()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_detalle_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idVenta);
                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", idproducto);
                cmd.Parameters.AddWithValue("@cantidad", txtpantalla);
                cmd.Parameters.AddWithValue("@preciounitario", txtPrecio_Unitario);
                cmd.Parameters.AddWithValue("@moneda", 0);
                cmd.Parameters.AddWithValue("@unidades", "Unidad");
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla);
                cmd.Parameters.AddWithValue("@Estado", "EN ESPERA");
                cmd.Parameters.AddWithValue("@Descripcion", lblDescripcion.Text);
                cmd.Parameters.AddWithValue("@Codigo", lblCodigo.Text);
                cmd.Parameters.AddWithValue("@Stock", lblStock_De_Productos);
                cmd.Parameters.AddWithValue("@Se_vende_a", sevendePor);
                cmd.Parameters.AddWithValue("@Usa_inventarios",  usaInventarios);
                cmd.Parameters.AddWithValue("@Costo", lblCosto.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                disminuir_stock_en_detalle_de_venta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }


       

        private void insertar_detalle_venta_SIN_VALIDAR()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_detalle_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idVenta);
                cmd.Parameters.AddWithValue("@Id_presentacionfraccionada", idproducto);
                cmd.Parameters.AddWithValue("@cantidad", txtpantalla);
                cmd.Parameters.AddWithValue("@preciounitario", txtPrecio_Unitario);
                cmd.Parameters.AddWithValue("@moneda", 0);
                cmd.Parameters.AddWithValue("@unidades", "Unidad");
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla);
                cmd.Parameters.AddWithValue("@Estado", "EN ESPERA");
                cmd.Parameters.AddWithValue("@Descripcion", lblDescripcion.Text);
                cmd.Parameters.AddWithValue("@Codigo", lblCodigo.Text);
                cmd.Parameters.AddWithValue("@Stock", lblStock_De_Productos);
                cmd.Parameters.AddWithValue("@Se_vende_a", sevendePor);
                cmd.Parameters.AddWithValue("@Usa_inventarios",  usaInventarios);
                cmd.Parameters.AddWithValue("@Costo", lblCosto.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
        private void contar_stock_detalle_ventas()
        {
            int x;
            x = datalistadoStockDetalleVenta2.Rows.Count;
            Contador_stock_detalle_de_venta = (x);
        }
        private void mostrar_stock_de_detalle_de_ventas()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_stock_de_detalle_de_ventas", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_producto", idproducto);
                da.Fill(dt);
                datalistadoStockDetalleVenta2.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
      

        private void ejecutar_editar_detalle_venta_sumar()
        {
            try
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                cmd = new SqlCommand("editar_detalle_venta_sumar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_producto", idproducto);
                cmd.Parameters.AddWithValue("@cantidad", txtpantalla);
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla);
                cmd.Parameters.AddWithValue("@Id_venta", idVenta);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
                       
        }
        public void disminuir_stock_en_detalle_de_venta()
        {

            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("disminuir_stock_en_detalle_de_venta", CONEXION.CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Producto1", idproducto);
                cmd.Parameters.AddWithValue("@cantidad", txtpantalla);
                cmd.ExecuteNonQuery();
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {


            }
        }
        private void Obtener_datos_del_detalle_de_venta()
        {
            try
            {
                iddetalleventa = Convert.ToInt32(datalistadoDetalleVenta.SelectedCells[9].Value.ToString());
                idproducto = Convert.ToInt32(datalistadoDetalleVenta.SelectedCells[8].Value.ToString());
                sevendePor = datalistadoDetalleVenta.SelectedCells[17].Value.ToString();
                usaInventarios = datalistadoDetalleVenta.SelectedCells[16].Value.ToString();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void editar_detalle_venta_sumar()
        {
                txtpantalla = 1;
                if (usaInventarios == "SI")
                {
                   lblStock_De_Productos =Convert.ToDouble( datalistadoDetalleVenta.SelectedCells[15].Value.ToString());
                   if(lblStock_De_Productos>0)
                    {
                        ejecutar_editar_detalle_venta_sumar();
                        disminuir_stock_en_detalle_de_venta();
                    }
                    else
                    {
                        timerLABEL_Stock.Start();
                    }
                }
                else
                {
                    ejecutar_editar_detalle_venta_sumar();
                }
                Listarproductosagregados();
        }
        private void editar_detalle_venta_restar()
        {
            txtpantalla = 1;
            if (usaInventarios == "SI")
            {
                ejecutar_editar_detalle_venta_restar();
                aumentar_stock_en_detalle_de_venta();
            }
            else
            {
                ejecutar_editar_detalle_venta_restar();
            }
            Listarproductosagregados();

        }

        private void aumentar_stock_en_detalle_de_venta()
        {
            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("aumentar_stock_en_detalle_de_venta", CONEXION.CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Producto1", idproducto);
                cmd.Parameters.AddWithValue("@cantidad", txtpantalla);
                cmd.ExecuteNonQuery();
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
        }
       private void ejecutar_editar_detalle_venta_restar()
        {
        try
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                cmd = new SqlCommand("editar_detalle_venta_restar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalle_venta", iddetalleventa);
                cmd.Parameters.AddWithValue("cantidad", txtpantalla);
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtpantalla);
                cmd.Parameters.AddWithValue("@Id_producto", idproducto);
                cmd.Parameters.AddWithValue("@Id_venta", idVenta);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DatalistadoDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Obtener_datos_del_detalle_de_venta();

            if (e.ColumnIndex == this.datalistadoDetalleVenta.Columns["S"].Index)
            {
                editar_detalle_venta_sumar();
            }
            if (e.ColumnIndex == this.datalistadoDetalleVenta.Columns["R"].Index)
            {
                editar_detalle_venta_restar();
                contar_tablas_ventas();
                if (contador == 0)
                {
                    eliminar_venta_al_agregar_productos();
                    txtVentaGenerada = "VENTA NUEVA";
                }
            }


            if (e.ColumnIndex == this.datalistadoDetalleVenta.Columns["EL"].Index)
            {
                foreach (DataGridViewRow row in datalistadoDetalleVenta.SelectedRows)
                {
                    int iddetalle_venta = Convert.ToInt32(row.Cells["iddetalle_venta"].Value);
                    try
                    {
                        SqlCommand cmd;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                        con.Open();
                        cmd = new SqlCommand("eliminar_detalle_venta", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iddetalleventa", iddetalle_venta);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Listarproductosagregados();
            }
        }
        private void eliminar_venta_al_agregar_productos()
        {
            try
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                cmd = new SqlCommand("eliminar_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idVenta);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void contar_tablas_ventas()
        {
            int x;
            x = datalistadoDetalleVenta.Rows.Count;
            contador = (x);
        }
        private void DatalistadoDetalleVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obtener_datos_del_detalle_de_venta();
            if (e.KeyChar == Convert.ToChar("+"))
            {
                editar_detalle_venta_sumar();
            }
            if (e.KeyChar == Convert.ToChar("-"))
            {
                editar_detalle_venta_restar();
                contar_tablas_ventas();
                if (contador == 0)
                {
                    eliminar_venta_al_agregar_productos();
                    txtVentaGenerada = "VENTA NUEVA";
                }
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "0";
        }
        bool SECUENCIA = true;
        private void BtnSeparador_Click(object sender, EventArgs e)
        {
            if(SECUENCIA == true)
            {
                txtmonto.Text = txtmonto.Text + ".";
                SECUENCIA = false;
            }
            else
            {
                return;
            }
        }

        private void Btnborrartodo_Click(object sender, EventArgs e)
        {
            txtmonto.Clear();
            SECUENCIA = true;
        }

        private void Txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') || (e.KeyChar != ','))
            {


                string CultureName = Thread.CurrentThread.CurrentCulture.Name;
                CultureInfo ci = new CultureInfo(CultureName);


                ci.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = ci;

            }
            Separador_de_Numeros(txtmonto, e);
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

        private void TimerBUSCADORcodigodebarras_Tick(object sender, EventArgs e)
        {
            timerBUSCADORcodigodebarras.Stop();
            vender_por_lectora_de_barras();

        }
        private void vender_por_lectora_de_barras()
        {
            if (txtbuscar.Text == "")
            {
                DATALISTADO_PRODUCTOS_OKA.Visible = false;
                lbltipodebusqueda2.Visible = true;
            }
            if (txtbuscar.Text != "")
            {
                DATALISTADO_PRODUCTOS_OKA.Visible = true;
                lbltipodebusqueda2.Visible = false;
                LISTAR_PRODUCTOS_Abuscador();

                idproducto = Convert.ToInt32(DATALISTADO_PRODUCTOS_OKA.SelectedCells[1].Value.ToString());
                mostrar_stock_de_detalle_de_ventas();
                contar_stock_detalle_ventas();

                if (Contador_stock_detalle_de_venta == 0)
                {
                    lblStock_De_Productos = Convert.ToDouble(DATALISTADO_PRODUCTOS_OKA.SelectedCells[4].Value.ToString());
                }
                else
                {
                    lblStock_De_Productos = Convert.ToDouble(datalistadoStockDetalleVenta2.SelectedCells[1].Value.ToString());
                }
                 usaInventarios = DATALISTADO_PRODUCTOS_OKA.SelectedCells[3].Value.ToString();
                lblDescripcion.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[9].Value.ToString();
                lblCodigo.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[10].Value.ToString();
                lblCosto.Text = DATALISTADO_PRODUCTOS_OKA.SelectedCells[5].Value.ToString();
                txtPrecio_Unitario =Convert.ToDouble( DATALISTADO_PRODUCTOS_OKA.SelectedCells[6].Value.ToString());
                sevendePor = DATALISTADO_PRODUCTOS_OKA.SelectedCells[8].Value.ToString();
                if (sevendePor == "Unidad")
                {
                    txtpantalla = 1;
                    vender_por_unidad();
                }

            }
        }
        private void editar_detalle_venta_CANTIDAD()
        {
            try
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                cmd = new SqlCommand("editar_detalle_venta_CANTIDAD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_producto", idproducto);
                cmd.Parameters.AddWithValue("@cantidad", txtmonto.Text);
                cmd.Parameters.AddWithValue("@Cantidad_mostrada", txtmonto.Text);
                cmd.Parameters.AddWithValue("@id_venta", idVenta);
                cmd.ExecuteNonQuery();
                con.Close();
                Listarproductosagregados();
                txtmonto.Clear();
                txtmonto.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCantidad_Click(object sender, EventArgs e)
        {
            if(datalistadoDetalleVenta.RowCount>0)
            {

            
            if(sevendePor =="Unidad")
            {
                string ruta = txtmonto.Text;
                if (ruta.Contains("."))
                {
                    MessageBox.Show("Este producto no acepta decimales ya que esta conigurado para ser vendido por UNIDAD", "Formato Icorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                        if(txtmonto.Text=="")
                        {
                            txtmonto.Text =Convert.ToString (0);
                        }
                        if(Convert.ToInt32( txtmonto.Text)>0)
                        {
                            editar_detalle_venta_CANTIDAD();
                        }
                        else
                        {
                            txtmonto.Clear();
                            txtmonto.Focus();
                        }
                    
                }
            }

          }
            else
            {
                txtmonto.Clear();
                txtmonto.Focus();
            }

        }

    

        private void BtnCobrar_Click_1(object sender, EventArgs e)
        {
            total = Convert.ToDouble(txt_total_suma.Text);
            VENTAS_MENU_PRINCIPAL.MEDIOS_DE_PAGO frm = new VENTAS_MENU_PRINCIPAL.MEDIOS_DE_PAGO();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();
        }

        private void frm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            Limpiar_para_venta_nueva();
        }

        private void TimerLABEL_Stock_Tick(object sender, EventArgs e)
        {
            
            if (progressBarETICKETA_Stock.Value < 100)
            {
                progressBarETICKETA_Stock.Value = progressBarETICKETA_Stock.Value + 10;
                LABEL_STOCK.Visible = true;
                LABEL_STOCK.Dock = DockStyle.Fill;
            }
            else
            {
                LABEL_STOCK.Visible = false;
                LABEL_STOCK.Dock = DockStyle.None;
                progressBarETICKETA_Stock.Value = 0;
                timerLABEL_Stock.Stop();
            }
        }

        private void PanelReferencia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            Ventas_en_espera frm = new Ventas_en_espera();
            frm.FormClosing += Frm_FormClosing1;
            frm.ShowDialog();
        }

        private void Frm_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Listarproductosagregados();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(datalistadoDetalleVenta.RowCount>0)
            {
         DialogResult Pregunta = MessageBox.Show("¿Realmente desea eliminar esta Venta?", "Eliminado registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(Pregunta==DialogResult.OK)
            {
                Eliminar_datos.eliminar_venta(idVenta);
                Limpiar_para_venta_nueva();
            }
           
            }

           
        }

        private void BtnPonerEspera_Click(object sender, EventArgs e)
        {
            if(datalistadoDetalleVenta.RowCount>0)
            {
                pnlEnEspera.Visible = true;
                pnlEnEspera.BringToFront();
                pnlEnEspera.Dock = DockStyle.Fill;
                txtNombre.Clear();
            }
           

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            ocultarPanelEspera();

        }
        private void ocultarPanelEspera()
        {
            pnlEnEspera.Visible = false;
            pnlEnEspera.Dock = DockStyle.None;
        }
        private void BtnGuardarEspera_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text))
            {
                editarVentaEspera();
            }
            else
            {
                MessageBox.Show("Ingrese una referencia");
            }
           

        }

        private void editarVentaEspera()
        {
            Editar_datos.ingresar_nombre_a_venta_en_espera(idVenta, txtNombre.Text);
            Limpiar_para_venta_nueva();
            ocultarPanelEspera();
        }

        private void BtnAutomaticosEspera_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Ticket" + idVenta;
            editarVentaEspera();

        }

        private void BtnVerMovimientosCaja_Click(object sender, EventArgs e)
        {
            CAJA.Listado_gastos_ingresos frm = new CAJA.Listado_gastos_ingresos();
            frm.ShowDialog();
        }

        private void BtnGastos_Click(object sender, EventArgs e)
        {
            GASTOS_VARIOS.Gastos frm= new GASTOS_VARIOS.Gastos();
            frm.ShowDialog();
        }
    }
}


