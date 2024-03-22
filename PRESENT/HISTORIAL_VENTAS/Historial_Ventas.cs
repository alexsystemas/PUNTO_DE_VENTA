using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.PRESENT.HISTORIAL_VENTAS
{
    public partial class Historial_Ventas : Form
    {
        public Historial_Ventas()
        {
            InitializeComponent();
        }
        int idventa;
        double Total;
        int iddetalleventa;
        double cantidad;
        string controlStock;
        int idproducto;
        double TotalNuevo;
        double PrecioUnitario;

        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscarVentas();
        }
        private void buscarVentas()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscarVentas(ref dt, txtbusca.Text);
            datalistadoVentas.DataSource = dt;
            datalistadoVentas.Columns[1].Visible = false;
            datalistadoVentas.Columns[4].Visible = false;
            datalistadoVentas.Columns[5].Visible = false;
            datalistadoVentas.Columns[6].Visible = false;
            datalistadoVentas.Columns[8].Visible = false;
            datalistadoVentas.Columns[9].Visible = false;
            datalistadoVentas.Columns[10].Visible = false;
            Bases.Multilinea(ref datalistadoVentas);

        }

        private void Historial_Ventas_Load(object sender, EventArgs e)
        {
            panelDerecha.Dock = DockStyle.Fill;
            pnlBienvenida.Dock = DockStyle.Fill;
        }

        private void DatalistadoVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
        }
        private void obtenerdatos()
        {
            if(datalistadoVentas.RowCount>0)
            {
                idventa =Convert.ToInt32(datalistadoVentas.SelectedCells[1].Value);
                lblComprobante.Text = datalistadoVentas.SelectedCells[3].Value.ToString();
                lbltotal.Text= datalistadoVentas.SelectedCells[4].Value.ToString();
                Total=Convert.ToDouble( datalistadoVentas.SelectedCells[4].Value.ToString());
                lblCajero.Text= datalistadoVentas.SelectedCells[5].Value.ToString();
                lblPagoCon.Text= datalistadoVentas.SelectedCells[6].Value.ToString();
                lblvuelto.Text= datalistadoVentas.SelectedCells[10].Value.ToString();
                lblTipoDePago.Text= datalistadoVentas.SelectedCells[9].Value.ToString();
                lblCliente.Text = datalistadoVentas.SelectedCells[8].Value.ToString();
                pnlDetalle.Visible = true;
                pnlCancelado.Visible = false;
                pnlBienvenida.Visible = false;
                pnlCantidad.Visible = false;
                pnlTicket.Visible = true;
                pnlDetalle.Dock = DockStyle.Fill;
                MostrardetalleVenta();

            }

        }
        private void MostrardetalleVenta()
        {
            DataTable dt = new DataTable();
            Obtener_datos.MostrarDetalleVenta(ref dt, idventa);
            datalistadoDetalleVenta.DataSource = dt;
        }

        private void DatalistadoDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==datalistadoDetalleVenta.Columns["Devolver"].Index)
            {
                obtenerDatosDetalle();
            }
        }
        private void obtenerDatosDetalle()
        {
            lblCantidadActual.Text = datalistadoDetalleVenta.SelectedCells[3].Value.ToString();
            cantidad = Convert.ToDouble(datalistadoDetalleVenta.SelectedCells[3].Value);
            PrecioUnitario =Convert.ToDouble (datalistadoDetalleVenta.SelectedCells[4].Value);
            idproducto = Convert.ToInt32(datalistadoDetalleVenta.SelectedCells[6].Value);
            iddetalleventa = Convert.ToInt32(datalistadoDetalleVenta.SelectedCells[7].Value);
            controlStock = datalistadoDetalleVenta.SelectedCells[14].Value.ToString();
            txtcantidad.Clear();
            txtcantidad.Focus();
            pnlCantidad.Visible = true;
            pnlDetalle.Visible = false;
    
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            pnlCantidad.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DetalleventaDevolucion();
        }
        private void DetalleventaDevolucion()
        {
            if(!string.IsNullOrEmpty(txtcantidad.Text))
            {
                double cantidadDevolucion;
                cantidadDevolucion =Convert.ToDouble( txtcantidad.Text);
                if(cantidadDevolucion>0)
                {
                    
                    if (cantidadDevolucion<=cantidad)
                    {
                        LdetalleVenta parametros = new LdetalleVenta();
                        Editar_datos funcion = new Editar_datos();
                        parametros.iddetalle_venta = iddetalleventa;
                        parametros.cantidad = Convert.ToDouble(cantidadDevolucion);
                        parametros.Cantidad_mostrada = Convert.ToDouble(cantidadDevolucion);
                        if (funcion.DetalleventaDevolucion(parametros) == true)
                        {
                            if(controlStock=="SI")
                            {
                                aumentarStock();
                                AumentarStockDetalle();
                                insertar_KARDEX_Entrada();
                                lbltotal.Text = TotalNuevo.ToString();
                                EditarVenta();
                                pnlCantidad.Visible = false;
                                ValidarPaneles();
                                buscarVentas();
                            }
                            else
                            {

                            }
                        }
                    }
                }
               
            }
           
        }
        private void ValidarPaneles()
        {
            if (TotalNuevo==0)
            {
                pnlTicket.Visible = false;
                pnlCancelado.Visible = true;
                pnlCancelado.Dock = DockStyle.Fill;
                pnlDetalle.Visible = false;
                pnlBienvenida.Visible = false;

            }
        }
        private void EditarVenta()
        {
            LVentass parametros = new LVentass();
            Editar_datos funcion = new Editar_datos();
            parametros.idventa = idventa;
            parametros.Monto_total = TotalNuevo;
            funcion.EditarVenta(parametros);

        }
        private void insertar_KARDEX_Entrada()
        {
            LKardex parametros = new LKardex();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Fecha = DateTime.Now;
            parametros.Motivo = "Devolucion de producto Venta #" + lblComprobante.Text;
            parametros.Cantidad =Convert.ToDouble( txtcantidad.Text);
            parametros.Id_producto = idproducto;
            funcion.insertar_KARDEX_entrada(parametros);

        }
        private void aumentarStock()
        {
            Lproductos parametros = new Lproductos();
            Editar_datos funcion = new Editar_datos();
            parametros.Id_Producto1 = idproducto;
            parametros.Stock = txtcantidad.Text;
            funcion.aumentarStock(parametros);
        }
        private void AumentarStockDetalle()
        {
            LdetalleVenta parametros = new LdetalleVenta();
            Editar_datos funcion = new Editar_datos();
            parametros.Id_producto = idproducto;
            parametros.cantidad =Convert.ToDouble( txtcantidad.Text);
            funcion.AumentarStockDetalle(parametros);
        }

        private void Txtcantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularNuevoTotal();
        }
        private void CalcularNuevoTotal()
        {
            try
            {
                double CantidadTexto;
                CantidadTexto =Convert.ToDouble (txtcantidad.Text);
                TotalNuevo = Total - (CantidadTexto * PrecioUnitario);
            }
            catch (Exception)
            {

                
            }
        }

    }
}
