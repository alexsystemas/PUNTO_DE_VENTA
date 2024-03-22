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


namespace PUNTO_DE_VENTA.PRESENT.INVENTARIOS_KARDEX
{
    public partial class kardex_entrada : Form
    {
        public kardex_entrada()
        {
            InitializeComponent();
        }
        int idProducto;
        double cantidadActual;
        double precioVentaActual;
        double costoActual;
        double precioMayoreoActual;

        double precioVentaNuevo;
        double CostoNuevo;
        double precioMayoreoNuevo;
        double cantidadAgregar;
        double CostoAgregado;


        private void TxtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            BUSCAR_PRODUCTOS_KARDEX();
        }
        private void BUSCAR_PRODUCTOS_KARDEX()
        {
            DataTable dt = new DataTable();
            Obtener_datos.BUSCAR_PRODUCTOS_KARDEX(ref dt,txtBuscarProducto.Text);
            DatalistadoProductos.DataSource = dt;
            DatalistadoProductos.Visible = true;
            DatalistadoProductos.Columns[1].Visible = false;
            DatalistadoProductos.Columns[2].Visible = true;
            DatalistadoProductos.Columns[3].Visible = false;
            DatalistadoProductos.Columns[4].Visible = false;
            DatalistadoProductos.Columns[5].Visible = false;
            DatalistadoProductos.Columns[6].Visible = false;
            DatalistadoProductos.Columns[7].Visible = false;
            DatalistadoProductos.Columns[8].Visible = false;
            DatalistadoProductos.Columns[9].Visible = false;
            DatalistadoProductos.Columns[10].Visible = true;
            DatalistadoProductos.Columns[11].Visible = false;
            DatalistadoProductos.Columns[12].Visible = false;
            DatalistadoProductos.Columns[13].Visible = false;
            DatalistadoProductos.Columns[14].Visible = false;
            DatalistadoProductos.Columns[15].Visible = false;
            DatalistadoProductos.Columns[16].Visible = false;

            Bases.Multilinea(ref DatalistadoProductos);

        }
        private void DatalistadoProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            obtener_datos();
        }

        private void obtener_datos()
        {
            idProducto =Convert.ToInt32( DatalistadoProductos.SelectedCells[1].Value);
            cantidadActual=Convert.ToDouble( DatalistadoProductos.SelectedCells[6].Value);
            costoActual = Convert.ToDouble(DatalistadoProductos.SelectedCells[7].Value);
            precioVentaActual = Convert.ToDouble(DatalistadoProductos.SelectedCells[9].Value);
            precioMayoreoActual= Convert.ToDouble(DatalistadoProductos.SelectedCells[14].Value);

            lblcantidadActual.Text = cantidadActual.ToString();
            txtCosto.Text = costoActual.ToString();
            txt_P_Venta.Text = precioVentaActual.ToString();
            txtPrecioMayoreo.Text = precioMayoreoActual.ToString();
            lblAnuciosNuevosPrecios.Text = "";
            txtAgregar.Text = "";
            pnletiqueta.Visible = false;
            if (precioMayoreoActual == 0)
                {
                    lblPMay.Visible = false;
                    txtPrecioMayoreo.Visible = false;
                }
                else
                {
                    lblPMay.Visible = true;
                    txtPrecioMayoreo.Visible = true;
                }
            txtBuscarProducto.Text = DatalistadoProductos.SelectedCells[2].Value.ToString();
            DatalistadoProductos.Visible = false;


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            validaciones();
        }
        private void EditarPreciosProductos()
        {
            Lproductos parametros = new Lproductos();
            Editar_datos funcion = new Editar_datos();
            parametros.Id_Producto1 = idProducto;
            parametros.Precio_de_venta =Convert.ToDouble( txt_P_Venta.Text);
            parametros.Precio_de_compra = CostoNuevo;
            parametros.Precio_mayoreo = Convert.ToDouble(txtPrecioMayoreo.Text);
            parametros.Stock = txtAgregar.Text;
            if(funcion.EditarPreciosProductos(parametros)==true)
            {
                insertar_KARDEX_Entrada();
            }
        }
        private void insertar_KARDEX_Entrada()
        {
            LKardex parametros = new LKardex();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Fecha = txtFecha.Value;
            parametros.Motivo = txtcMotivo.Text;
            parametros.Cantidad =Convert.ToDouble( txtAgregar.Text);
            parametros.Id_producto = idProducto;
            if (funcion.insertar_KARDEX_entrada(parametros) == true)
            {
                txtBuscarProducto.Text = "";
                txtBuscarProducto.Focus();
                DatalistadoProductos.Visible = true;
                MessageBox.Show("Registro realizado correctamente");
            }

        }
        private void validaciones()
        {
            if (!string.IsNullOrEmpty(txtAgregar.Text))
            {
                if (!string.IsNullOrEmpty(txtCosto.Text))
                {
                    if (!string.IsNullOrEmpty(txt_P_Venta.Text))
                    {
                        if (!string.IsNullOrEmpty(txtPrecioMayoreo.Text))
                        {
                            if (string.IsNullOrEmpty(txtcMotivo.Text))
                            {
                                txtcMotivo.Text = "SIN MOTIVO";
                            }
                            EditarPreciosProductos();
                        }
                        else
                        {
                            MessageBox.Show("El precio de venta al por mayor no puede estar vacio", "Valores vacios");
                            txtPrecioMayoreo.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("El precio de venta no puede estar vacio", "Valores vacios");
                        txt_P_Venta.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El Costo no puede estar vacio", "Valores vacios");
                    txtCosto.Focus();
                }

            }
            else
            {
                MessageBox.Show("El valor a agregar no puede estar vacio", "Valores vacios");
                txtAgregar.Focus();
            }


        }

        private void TxtAgregar_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular()
        {
            if(!string.IsNullOrEmpty(txtAgregar.Text))
            {
                if (!string.IsNullOrEmpty(txtCosto.Text))
                {
                    pnletiqueta.Visible = true;
                    cantidadAgregar = Convert.ToDouble(txtAgregar.Text);
                    CostoAgregado = Convert.ToDouble(txtCosto.Text);
                    CostoNuevo = ((costoActual * cantidadActual) + (CostoAgregado * cantidadAgregar)) / (cantidadActual + cantidadAgregar);
                    lblAnuciosNuevosPrecios.Text = "Se recibiran" + txtAgregar.Text + "de stock, el nuevo costo sera de: " + CostoNuevo.ToString();
                }
            }
                
        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void Kardex_entrada_Load(object sender, EventArgs e)
        {
            lblAnuciosNuevosPrecios.Text = "";
        }
    }
}
