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
using System.IO.Ports;

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
        string ResultadoLicencia;
        string FechaFinal;
        double cantidad;
        string Tema;
        string ip;
        int contadorVentasEspera;
        bool estadoCobrar=false;
        public static bool EstadosMediosPago = false;
        Panel panel_mostrador_de_productos = new Panel();
      


        private void VENTAS_MENU_PRINCIPALOK_Load(object sender, EventArgs e)
        {

            validarLicencia();

            Bases.Cambiar_idioma_regional();
            Bases.Obtener_serialPC(ref SerialPC);
            // CONEXION.Obtener_serial_de_PC.ObtenerSerialPC(ref lblSerialPc);

            Obtener_datos.obtener_id_caja_PorSerial(ref Id_caja);
           
          
            Obtener_id_de_cliente_estandar();
            Obtener_datos.mostrar_inio_de_secion(ref idusuario_que_inicio_sesion);
            txtbuscar.Focus();
            dgDetalleDeVenta.Visible = false;
            if (Tipo_de_busqueda == "TECLADO")
            {
                lbltipodebusqueda2.Text = "Buscar con TECLADO";
                btnScanner.BackColor = Color.WhiteSmoke;
                btnTeclado.BackColor = Color.LightGreen;
            }
            else
            {
                lbltipodebusqueda2.Text = "Buscar con LECTORA de Codigos de Barras";
                btnScanner.BackColor = Color.LightGreen;
                btnTeclado.BackColor = Color.WhiteSmoke;
            }
            ValidarTemaCaja();
            Limpiar_para_venta_nueva();
            ObtenerIPlocal();
            contarVentasEspera();




        }
        private void validarTiposDeBusquedas()
        {
            MOSTRAR_TIPO_DE_BUSQUEDA();
            if (Tipo_de_busqueda == "TECLADO")
            {
                lbltipodebusqueda2.Text = "Buscar con TECLADO";
                btnScanner.BackColor = Color.WhiteSmoke;
                btnTeclado.BackColor = Color.LightGreen;
                dgDetalleDeVenta.Visible = true;
                txtbuscar.Clear();
                txtbuscar.Focus();
            }
            else
            {
                lbltipodebusqueda2.Text = "Buscar con LECTORA de Codigos de Barras";
                btnScanner.BackColor = Color.LightGreen;
                btnTeclado.BackColor = Color.WhiteSmoke;
                dgDetalleDeVenta.Visible = true;
                txtbuscar.Clear();
                txtbuscar.Focus();
            }
        }

        private void ObtenerIPlocal()
        {

            this.Text = Bases.ObtenerIP(ref ip);
        }
        public void contarVentasEspera()
        {
            Obtener_datos.contarVentasEspera(ref contadorVentasEspera);
            if(contadorVentasEspera==0)
            {
                pnlNotificacionEspera.Visible = false;
            }
            else
            {
                pnlNotificacionEspera.Visible = true;
                lblContador.Text = contadorVentasEspera.ToString();
            }

        }

        private void ValidarTemaCaja()
        {
            Obtener_datos.mostrarTemaCaja(ref Tema);
            if (Tema == "Redentor")
            {
                Temaclaro();
                IndicadorTema.Checked = false;
            }
            else
            {

                oscuro();
                IndicadorTema.Checked = true;
            }
        }

        private void EditarTemaCaja()
        {
            Lcaja parametros = new Lcaja();
            Editar_datos funcion = new Editar_datos();
            parametros.Tema = Tema;
            funcion.EditarTemaCaja(parametros);
        }
        private void validarLicencia()
        {
            DLicencias funcion = new DLicencias();
            funcion.ValidarLicencias(ref ResultadoLicencia, ref FechaFinal);
            
            if (ResultadoLicencia == "VENCIDA")

            {
                funcion.EditarMarcanVencidas();
                Dispose();
                LICENCIAS_MEMBRESIAS.Membresias frm = new LICENCIAS_MEMBRESIAS.Membresias();
                frm.ShowDialog();

            }



        }
        private void Limpiar_para_venta_nueva()
        {
            
            idVenta = 0;
            Listarproductosagregados();
            txtVentaGenerada = "VENTA NUEVA";
            sumar();
            pnlEnEspera.Visible = false;
            contarVentasEspera();
            EstadosMediosPago = false;
        }
        private void sumar()
        {
            try
            {

                int x;
                x = dgDetalleDeVenta.Rows.Count;
                if (x == 0)
                {
                    txt_total_suma.Text = "0.00";
                }

                double totalpagar;
                totalpagar = 0;
                foreach (DataGridViewRow fila in dgDetalleDeVenta.Rows)
                {

                    totalpagar += Convert.ToDouble(fila.Cells["Importe"].Value);
                    Math.Round(totalpagar);
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
                dgProductos.DataSource = dt;
                CONEXION.CONEXIONMAESTRA.cerrar();
                dgProductos.Columns[0].Visible = false;
                dgProductos.Columns[1].Visible = false;
                dgProductos.Columns[2].Width = 645;
                dgProductos.Columns[3].Visible = false;
                dgProductos.Columns[4].Visible = false;
                dgProductos.Columns[5].Visible = false;
                dgProductos.Columns[6].Visible = false;
                dgProductos.Columns[7].Visible = false;
                dgProductos.Columns[8].Visible = false;
                dgProductos.Columns[9].Visible = false;
                dgProductos.Columns[10].Visible = false;

                dgDetalleDeVenta.Visible = true;
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
               // MessageBox.Show(ex.StackTrace);
            }
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            CAJA.lblVentasTotal frm = new CAJA.lblVentasTotal();
            frm.ShowDialog();
        }

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            PRODUCTOS_OK.Productos_OK frm = new PRODUCTOS_OK.Productos_OK();
            frm.ShowDialog();
        }

        private void BtnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            Dispose();
            CAJA.lblVentasTotal frm = new CAJA.lblVentasTotal();
            frm.ShowDialog();
        }

        

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            Dispose();
            CONFIGURACION.PANEL_CONFIGURACIONES frm = new CONFIGURACION.PANEL_CONFIGURACIONES();
            frm.ShowDialog();
        }


     
      
        private void BtnTeclado_Click_1(object sender, EventArgs e)
        {
            modoTeclado();
        }
        private void modoTeclado()
        {
            ocultar_productos();
            lbltipodebusqueda2.Text = "Buscar con  TECLADO";
            Tipo_de_busqueda = "TECLADO";
            btnTeclado.BackColor = Color.LightGreen;
            btnScanner.BackColor = Color.WhiteSmoke;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }

        private void BtnScanner_Click(object sender, EventArgs e)
        {
            modoScanner();
        }


        private void modoScanner()
        {
            ocultar_productos();
            lbltipodebusqueda2.Text = "Buscar con LECTORA de Codigos de Barras";
            Tipo_de_busqueda = "LECTORA";
            btnScanner.BackColor = Color.LightGreen;
            btnTeclado.BackColor = Color.WhiteSmoke;
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
            dgProductos.Visible = true;
            dgProductos.Dock = DockStyle.Fill;
            lbltipodebusqueda2.Visible = false;
            panel_mostrador_de_productos.Controls.Add(dgProductos);
            this.Controls.Add(panel_mostrador_de_productos);
            panel_mostrador_de_productos.BringToFront();


        }

        private void ocultar_productos()
        {
            panel_mostrador_de_productos.Visible = false;
            dgProductos.Visible = false;
            lbltipodebusqueda2.Visible = true;
        }
    

        private void DATALISTADO_PRODUCTOS_OKA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            vender_por_teclado();

        }
        public void ValidarVentasNuevas()
        {
            if(dgDetalleDeVenta.RowCount==0)
            {
                Limpiar_para_venta_nueva();
            }
        }

        private void vender_por_teclado()
        {
            ValidarVentasNuevas();
            txtbuscar.Text = dgProductos.SelectedCells[10].Value.ToString();
            idproducto = Convert.ToInt32(dgProductos.SelectedCells[1].Value.ToString());
            // mostramos los registros del producto en el detalle de venta
            mostrar_stock_de_detalle_de_ventas();
            contar_stock_detalle_ventas();

            if (Contador_stock_detalle_de_venta == 0)
            {
                // Si es producto no esta agregado a las ventas se tomara el Stock de la tabla Productos
                lblStock_De_Productos = Convert.ToDouble(dgProductos.SelectedCells[4].Value.ToString());
            }
            else
            {
                //en caso que el producto ya este agregado al detalle de venta se va a extraer el Stock de la tabla Detalle_de_venta
                lblStock_De_Productos = Convert.ToDouble(datalistadoStockDetalleVenta2.SelectedCells[1].Value.ToString());
            }
            //Extraemos los datos del producto de la tabla Productos directamente
            usaInventarios = dgProductos.SelectedCells[3].Value.ToString();
            lblDescripcion.Text = dgProductos.SelectedCells[9].Value.ToString();
            lblCodigo.Text = dgProductos.SelectedCells[10].Value.ToString();
            lblCosto.Text = dgProductos.SelectedCells[5].Value.ToString();
            sevendePor = dgProductos.SelectedCells[8].Value.ToString();
            txtPrecio_Unitario =Convert.ToDouble( dgProductos.SelectedCells[6].Value.ToString());
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
            SqlCommand com = new SqlCommand("select idclientev  from clientes where Estado=0", con);
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
               // MessageBox.Show("idVenta:" + idVenta);
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
                if (txtbuscar.Text == dgProductos.SelectedCells[10].Value.ToString())
                {
                    dgProductos.Visible = true;
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
                dgDetalleDeVenta.DataSource = dt;
                con.Close();
                dgDetalleDeVenta.Columns[0].Width = 50;
                dgDetalleDeVenta.Columns[1].Width = 50;
                dgDetalleDeVenta.Columns[2].Width = 50;
                dgDetalleDeVenta.Columns[3].Visible = false;
                dgDetalleDeVenta.Columns[4].Width = 250;
                dgDetalleDeVenta.Columns[5].Width = 100;
                dgDetalleDeVenta.Columns[6].Width = 100;
                dgDetalleDeVenta.Columns[7].Width = 100;
                dgDetalleDeVenta.Columns[8].Visible = false;
                dgDetalleDeVenta.Columns[9].Visible = false;
                dgDetalleDeVenta.Columns[10].Visible = false;
                dgDetalleDeVenta.Columns[11].Width = dgDetalleDeVenta.Width - (dgDetalleDeVenta.Columns[0].Width - dgDetalleDeVenta.Columns[1].Width - dgDetalleDeVenta.Columns[2].Width -
                dgDetalleDeVenta.Columns[4].Width - dgDetalleDeVenta.Columns[5].Width - dgDetalleDeVenta.Columns[6].Width - dgDetalleDeVenta.Columns[7].Width);
                dgDetalleDeVenta.Columns[12].Visible = false;
                dgDetalleDeVenta.Columns[13].Visible = false;
                dgDetalleDeVenta.Columns[14].Visible = false;
                dgDetalleDeVenta.Columns[15].Visible = false;
                dgDetalleDeVenta.Columns[16].Visible = false;
                dgDetalleDeVenta.Columns[17].Visible = false;
                dgDetalleDeVenta.Columns[18].Visible = false;
                Bases.Multilinea(ref dgDetalleDeVenta);
                sumar();
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
                iddetalleventa = Convert.ToInt32(dgDetalleDeVenta.SelectedCells[9].Value.ToString());
                idproducto = Convert.ToInt32(dgDetalleDeVenta.SelectedCells[8].Value.ToString());
                sevendePor = dgDetalleDeVenta.SelectedCells[17].Value.ToString();
                usaInventarios = dgDetalleDeVenta.SelectedCells[16].Value.ToString();
                cantidad=Convert.ToDouble( dgDetalleDeVenta.SelectedCells[5].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void editar_detalle_venta_sumar()
        {
               
                if (usaInventarios == "SI")
                {
                   lblStock_De_Productos =Convert.ToDouble( dgDetalleDeVenta.SelectedCells[15].Value.ToString());
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

            if (e.ColumnIndex == this.dgDetalleDeVenta.Columns["S"].Index)
            {
                txtpantalla = 1;
                editar_detalle_venta_sumar();
            }
            if (e.ColumnIndex == this.dgDetalleDeVenta.Columns["R"].Index)
            {
                txtpantalla = 1;
                editar_detalle_venta_restar();
                contar_tablas_ventas();
                
            }


            if (e.ColumnIndex == this.dgDetalleDeVenta.Columns["EL"].Index)
            {
                foreach (DataGridViewRow row in dgDetalleDeVenta.SelectedRows)
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
            x = dgDetalleDeVenta.Rows.Count;
            contador = (x);
        }
        private void DatalistadoDetalleVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(dgDetalleDeVenta.RowCount>0)
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
        }
        private void Btn1_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "1";
        }
        private void Btn2_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "2";
        }

      
          private void Btn3_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "3";
        }

        private void Btn4_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "4";
        }

        private void Btn5_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "5";
        }

        private void Btn6_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "6";
        }

        private void Btn7_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "7";
        }

        private void Btn8_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "8";
        }

        private void Btn9_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "9";
        }

        private void Btn0_Click_1(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "0";
        }

        private void BtnSeparador_Click_1(object sender, EventArgs e)
        {
            if (SECUENCIA == true)
            {
                txtmonto.Text = txtmonto.Text + ".";
                SECUENCIA = false;
            }
            else
            {
                return;
            }
        }

        private void Btnborrartodo_Click_1(object sender, EventArgs e)
        {
            txtmonto.Clear();
            SECUENCIA = true;
        }
        
        bool SECUENCIA = true;
        
        private void TimerBUSCADORcodigodebarras_Tick(object sender, EventArgs e)
        {
            timerBUSCADORcodigodebarras.Stop();
            vender_por_lectora_de_barras();

        }
        private void vender_por_lectora_de_barras()
        {
            if (txtbuscar.Text == "")
            {
                dgProductos.Visible = false;
                lbltipodebusqueda2.Visible = true;
            }
            if (txtbuscar.Text != "")
            {
                dgProductos.Visible = true;
                lbltipodebusqueda2.Visible = false;
                LISTAR_PRODUCTOS_Abuscador();

                idproducto = Convert.ToInt32(dgProductos.SelectedCells[1].Value.ToString());
                mostrar_stock_de_detalle_de_ventas();
                contar_stock_detalle_ventas();

                if (Contador_stock_detalle_de_venta == 0)
                {
                    lblStock_De_Productos = Convert.ToDouble(dgProductos.SelectedCells[4].Value.ToString());
                }
                else
                {
                    lblStock_De_Productos = Convert.ToDouble(datalistadoStockDetalleVenta2.SelectedCells[1].Value.ToString());
                }
                 usaInventarios = dgProductos.SelectedCells[3].Value.ToString();
                lblDescripcion.Text = dgProductos.SelectedCells[9].Value.ToString();
                lblCodigo.Text = dgProductos.SelectedCells[10].Value.ToString();
                lblCosto.Text = dgProductos.SelectedCells[5].Value.ToString();
                txtPrecio_Unitario =Convert.ToDouble( dgProductos.SelectedCells[6].Value.ToString());
                sevendePor = dgProductos.SelectedCells[8].Value.ToString();
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

       

    

        private void BtnCobrar_Click_1(object sender, EventArgs e)
        {
            Cobrar();
        }
        private void Cobrar()
        {
            if (dgDetalleDeVenta.RowCount>0)
            {
                total = Convert.ToDouble(txt_total_suma.Text);
                VENTAS_MENU_PRINCIPAL.MEDIOS_DE_PAGO frm = new VENTAS_MENU_PRINCIPAL.MEDIOS_DE_PAGO();
                frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                frm.ShowDialog();
            }
          
        }
        private void frm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if(EstadosMediosPago==true)
            {
                Limpiar_para_venta_nueva();
            }
           
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
            if(dgDetalleDeVenta.RowCount>0)
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
            if(dgDetalleDeVenta.RowCount>0)
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

        private void BtnIngresos_Click(object sender, EventArgs e)
        {
            INGRESOS_VARIOS.IngresosVarios frm = new INGRESOS_VARIOS.IngresosVarios();
            frm.ShowDialog();
        }

        private void BtnCreditoPagar_Click(object sender, EventArgs e)
        {
            APERTURA_DE_CREDITO.PorPagar frm = new APERTURA_DE_CREDITO.PorPagar();
            frm.ShowDialog();
        }

        private void BtnCreditoCobrar_Click(object sender, EventArgs e)
        {
            APERTURA_DE_CREDITO.PorCobrar frm = new APERTURA_DE_CREDITO.PorCobrar();
            frm.ShowDialog();
        }

        private void VENTAS_MENU_PRINCIPALOK_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgRes = MessageBox.Show("¿Realmente desea Cerrar el Sistema ?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlgRes==DialogResult.Yes)
            {
                Dispose();
                COPIAS_BD.GeneradorAutomatico frm = new COPIAS_BD.GeneradorAutomatico();
                frm.ShowDialog();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void BtnCobros_Click(object sender, EventArgs e)
        {
            COBROS.CobrosForm frm = new COBROS.CobrosForm();
            frm.ShowDialog();
        }

        private void BtnMayoreo_Click(object sender, EventArgs e)
        {
            aplicar_precio_mayoreo();
        }
        private void aplicar_precio_mayoreo()
        {
            if(dgDetalleDeVenta.Rows.Count>0)
            {
                LdetalleVenta parametros = new LdetalleVenta();
                Editar_datos funcion = new Editar_datos();

                parametros.Id_producto = idproducto;
                parametros.iddetalle_venta = iddetalleventa;
                if (funcion.aplicar_precio_mayoreo(parametros) == true)
                {
                    Listarproductosagregados();
                }
           
            }
        }

        private void Txtmonto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtmonto, e);
        }

        private void BtnCantidad_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                if (dgDetalleDeVenta.RowCount > 0)
                {

                    if (sevendePor == "Unidad")

                    {
                        string cadena = txtmonto.Text;
                        if (cadena.Contains("."))
                        {
                            MessageBox.Show("Este Producto no acepta decimales ya que esta configurado para ser vendido por UNIDAD", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            BotonCantidad();


                        }
                    }
                    else if (sevendePor == "Granel")
                    {
                        BotonCantidad();
                    }
                }
                else
                {
                    txtmonto.Clear();
                    txtmonto.Focus();
                }
            }

        }
        private void BotonCantidad()
        {

            double MontoaIngresar;
            MontoaIngresar = Convert.ToDouble(txtmonto.Text);
            double Cantidad;
            Cantidad = Convert.ToDouble(dgDetalleDeVenta.SelectedCells[5].Value);

            double stock;
            double condicional;
            string ControlStock;
            ControlStock = dgDetalleDeVenta.SelectedCells[16].Value.ToString();
            if (ControlStock == "SI")
            {
                stock = Convert.ToDouble(dgDetalleDeVenta.SelectedCells[11].Value);
                condicional = Cantidad + stock;
                if (condicional >= MontoaIngresar)
                {
                    BotonCantidadEjecuta();
                }
                else
                {
                    timerLABEL_Stock.Start();
                }
            }
            else
            {
                BotonCantidadEjecuta();
            }


        }
        private void BotonCantidadEjecuta()
        {
            double MontoaIngresar;
            MontoaIngresar = Convert.ToDouble(txtmonto.Text);
            double Cantidad;
            Cantidad = Convert.ToDouble(dgDetalleDeVenta.SelectedCells[5].Value);

            if (MontoaIngresar > Cantidad)
            {
                txtpantalla = MontoaIngresar - Cantidad;
                editar_detalle_venta_sumar();
            }
            else if (MontoaIngresar < Cantidad)
            {
                txtpantalla = Cantidad - MontoaIngresar;
                editar_detalle_venta_restar();
            }
        }

        private void BtnPrecio_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtmonto.Text))
            {
                LdetalleVenta parametros = new LdetalleVenta();
                Editar_datos funcion = new Editar_datos();
                parametros.iddetalle_venta = iddetalleventa;
                parametros.preciounitario =Convert.ToDouble(txtmonto.Text);
                if(funcion.editarPrecioVenta(parametros)==true)
                {
                    Listarproductosagregados();
                }

            }
        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            HISTORIAL_VENTAS.Historial_Ventas frm = new HISTORIAL_VENTAS.Historial_Ventas();
            frm.ShowDialog();
        }
        private void UI_MaterialToggle1_CheckedChanged(object sender, EventArgs e)
        {

            if (IndicadorTema.Checked == true)
            {
                Tema = "Oscuro";
                EditarTemaCaja();
                oscuro();
                Listarproductosagregados();
            }
            else
            {
                Tema = "Redentor";
                EditarTemaCaja();
                Temaclaro();
                Listarproductosagregados();
            }
        }
        private void oscuro()
        {
            pnlToop.BackColor = Color.FromArgb(40, 45, 61);
            pnlFeel.BackColor = Color.FromArgb(40, 45, 61);
            pnlIzquierdo.BackColor = Color.FromArgb(40, 45, 61);
            pnlizqDerecha.BackColor = Color.FromArgb(48, 61, 81);
            pnlCentalDer.BackColor = Color.FromArgb(40, 45, 61);
            pnlCentroIzq.BackColor = Color.FromArgb(40, 45, 61);
            pnlLinea.BackColor = Color.FromArgb(77, 199, 201);
            pnlDevolucion.BackColor = Color.FromArgb(40, 45, 61);
            pnlColorTema.BackColor = Color.FromArgb(40, 45, 61);

            dgDetalleDeVenta.BackgroundColor = Color.FromArgb(40, 45, 61);

            lblTotal.ForeColor = Color.FromArgb(100, 101, 108);
            txt_total_suma.ForeColor = Color.FromArgb(100, 101, 108);

            txtbuscar.BackColor = Color.FromArgb(40, 45, 61);
            txtbuscar.ForeColor = Color.FromArgb(100, 101, 108);

            pnlSuspenciones.BackColor = Color.FromArgb(40, 45, 61);
            btnPonerEspera.BackColor = Color.FromArgb(40, 45, 61);
            btnPonerEspera.ForeColor = Color.FromArgb(100, 101, 108);
            btnRestaurar.BackColor = Color.FromArgb(40, 45, 61);
            btnRestaurar.ForeColor = Color.FromArgb(100, 101, 108);
            btnEliminar.BackColor = Color.FromArgb(40, 45, 61);
            btnEliminar.ForeColor = Color.FromArgb(100, 101, 108);
            btnDevoluciones.BackColor = Color.FromArgb(40, 45, 61);
            btnDevoluciones.ForeColor = Color.FromArgb(100, 101, 108);
            //btn_Scanner.BackColor = Color.FromArgb(40, 45, 61);
            //btn_Teclado.BackColor = Color.FromArgb(40, 45, 61);

            btnCobros.BackColor = Color.FromArgb(40, 45, 61);
            btnCobros.ForeColor = Color.FromArgb(100, 101, 108);
            btnPagos.BackColor = Color.FromArgb(40, 45, 61);
            btnPagos.ForeColor = Color.FromArgb(100, 101, 108);
            btnCreditoCobrar.BackColor = Color.FromArgb(40, 45, 61);
            btnCreditoCobrar.ForeColor = Color.FromArgb(100, 101, 108);
            btnCreditoPagar.BackColor = Color.FromArgb(40, 45, 61);
            btnCreditoPagar.ForeColor = Color.FromArgb(100, 101, 108);
            btnVerMovimientosCaja.BackColor = Color.FromArgb(40, 45, 61);
            btnVerMovimientosCaja.ForeColor = Color.FromArgb(100, 101, 108);
          
            btnIngresos.BackColor = Color.FromArgb(40, 45, 61);
            btnIngresos.ForeColor = Color.FromArgb(100, 101, 108);
            btnGastos.BackColor = Color.FromArgb(40, 45, 61);
            btnGastos.ForeColor = Color.FromArgb(100, 101, 108);

            lblTemaOscuro.ForeColor = Color.FromArgb(100, 101, 108);
            txtmonto.BackColor = Color.FromArgb(48, 61, 81);
            txtmonto.ForeColor = Color.FromArgb(100, 101, 108);
            Listarproductosagregados();

        }
        private void Temaclaro()
        {
            pnlToop.BackColor = Color.FromArgb(214, 250, 250);
            pnlFeel.BackColor = Color.FromArgb(214, 250, 250);
            pnlIzquierdo.BackColor = Color.FromArgb(214, 250, 250);
            pnlizqDerecha.BackColor = Color.FromArgb(0, 85, 128);
            pnlCentalDer.BackColor = Color.FromArgb(214, 250, 250);
            pnlCentroIzq.BackColor = Color.FromArgb(214, 250, 250);
            pnlLinea.BackColor = Color.FromArgb(0, 85, 128);
            pnlDevolucion.BackColor = Color.FromArgb(214, 250, 250);
            pnlColorTema.BackColor = Color.FromArgb(214, 250, 250);

            dgDetalleDeVenta.BackgroundColor = Color.FromArgb(214, 250, 250);

            lblTotal.ForeColor = Color.FromArgb(0, 85, 128);
            txt_total_suma.ForeColor = Color.FromArgb(0, 85, 128);

            txtbuscar.BackColor = Color.FromArgb(214, 250, 250);
            txtbuscar.ForeColor = Color.FromArgb(100, 101, 108);

            pnlSuspenciones.BackColor = Color.FromArgb(214, 250, 250);
            btnPonerEspera.BackColor = Color.FromArgb(214, 250, 250);
            btnPonerEspera.ForeColor = Color.FromArgb(0, 85, 128);
            btnRestaurar.BackColor = Color.FromArgb(214, 250, 250);
            btnRestaurar.ForeColor = Color.FromArgb(0, 85, 128);
            btnEliminar.BackColor = Color.FromArgb(214, 250, 250);
            btnEliminar.ForeColor = Color.FromArgb(0, 85, 128);
            btnDevoluciones.BackColor = Color.FromArgb(214, 250, 250);
            btnDevoluciones.ForeColor = Color.FromArgb(0, 85, 128);
            //btn_Scanner.BackColor = Color.FromArgb(40, 45, 61);
            //btn_Teclado.BackColor = Color.FromArgb(40, 45, 61);

            btnCobros.BackColor = Color.FromArgb(214, 250, 250);
            btnCobros.ForeColor = Color.FromArgb(0, 85, 128);
            btnPagos.BackColor = Color.FromArgb(214, 250, 250);
            btnPagos.ForeColor = Color.FromArgb(0, 85, 128);
            btnCreditoCobrar.BackColor = Color.FromArgb(214, 250, 250);
            btnCreditoCobrar.ForeColor = Color.FromArgb(0, 85, 128);
            btnCreditoPagar.BackColor = Color.FromArgb(214, 250, 250);
            btnCreditoPagar.ForeColor = Color.FromArgb(0, 85, 128);
            btnVerMovimientosCaja.BackColor = Color.FromArgb(214, 250, 250);
            btnVerMovimientosCaja.ForeColor = Color.FromArgb(0, 85, 128);
           
         
            btnIngresos.BackColor = Color.FromArgb(214, 250, 250);
            btnIngresos.ForeColor = Color.FromArgb(0, 85, 128);
            btnGastos.BackColor = Color.FromArgb(214, 250, 250);
            btnGastos.ForeColor = Color.FromArgb(0, 85, 128);

            lblTemaOscuro.ForeColor = Color.FromArgb(0, 85, 128);
            txtmonto.BackColor = Color.FromArgb(214, 250, 250);
            txtmonto.ForeColor = Color.FromArgb(0, 85, 128);
            Listarproductosagregados();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            INVENTARIOS_KARDEX.INVENTARIO_MENU frm = new INVENTARIOS_KARDEX.INVENTARIO_MENU();
            frm.ShowDialog();
        }

        private void DatalistadoDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrecioMayoreo_Click(object sender, EventArgs e)
        {
            aplicar_precio_mayoreo();
        }

        private void Txtbuscar_DoubleClick(object sender, EventArgs e)
        {
            txtbuscar.SelectAll();
        }

    

      

        private void BtnTeclado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.K))
            {
                MessageBox.Show(" Enter pressed ");
            }
            if (e.KeyChar == Convert.ToChar(Keys.L))
            {
                MessageBox.Show(" Enter pressed ");
            }
        }

        private void Txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            tiposDeBusquedas(e);
            EventosNavegarDgProductos(e);
            EventosNavegarDgDetalleDeVenta(e);
        }
        private void EventosNavegarDgDetalleDeVenta(KeyEventArgs e)
        {
            if (dgProductos.Visible == false)
            {
               
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    dgDetalleDeVenta.Focus();

                }
               
               
            }
        }
        private void EventosNavegarDgProductos(KeyEventArgs e)
        {
            estadoCobrar = true;
            if(dgProductos.Visible==true)
            {
                if(e.KeyCode==Keys.Enter)
                {
                    estadoCobrar = false;
                    vender_por_teclado();
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    dgProductos.Focus();

                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter && estadoCobrar==true)
                {
                    Cobrar();
                }
            }
        }

        private void DatalistadoDetalleVenta_KeyDown(object sender, KeyEventArgs e)
        {
            tiposDeBusquedas(e);
            EventoDeCobros(e);
        }
        private void EventoDeCobros(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgProductos.Visible==false)
            {
                Cobrar();
            }
        }

        private void tiposDeBusquedas(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                modoTeclado();
            }
            if (e.KeyCode == Keys.F2)
            {
                modoScanner();
            }
            if (e.KeyCode == Keys.Escape)
            {
                validarTiposDeBusquedas();
            }

        }

        private void DgProductos_KeyDown(object sender, KeyEventArgs e)
        {
            EventosNavegarDgProductos(e);
            tiposDeBusquedas(e);
        }

     
    }
}


