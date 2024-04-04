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
    public partial class KardexSalida : Form
    {
        public KardexSalida()
        {
            InitializeComponent();
        }
        int idProducto;
        double cantidadActual;

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            BUSCAR_PRODUCTOS_KARDEX();
        }
        private void BUSCAR_PRODUCTOS_KARDEX()
        {
            DataTable dt = new DataTable();
            Obtener_datos.BUSCAR_PRODUCTOS_KARDEX(ref dt, txtBuscarProducto.Text);
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
   

        private void validaciones()
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                if (string.IsNullOrEmpty(txtcMotivo.Text))
                {
                    txtcMotivo.Text = "SIN MOTIVO";
                }
                double cantDisminuir = Convert.ToDouble(txtCantidad.Text);
                if (cantDisminuir <= cantidadActual)
                {
                    disminuir_stock();
                }
                else
                {
                    MessageBox.Show("Se esta restando mas de lo que hay en Stock", "Error");

                }

            }
            else
            {
                MessageBox.Show("El valor a agregar no puede estar vacio", "Valores vacios");
                txtCantidad.Focus();
            }
        }
        private void insertar_KARDEX_SALIDA()
        {
            LKardex parametros = new LKardex();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Fecha = txtFecha.Value;
            parametros.Motivo = txtcMotivo.Text;
            parametros.Cantidad = Convert.ToDouble(txtCantidad.Text);
            parametros.Id_producto = idProducto;
            if (funcion.insertar_KARDEX_SALIDA(parametros) == true)
            {
                txtBuscarProducto.Text = "";
                txtBuscarProducto.Focus();
                DatalistadoProductos.Visible = true;
                MessageBox.Show("Registro realizado correctamente");
            }

        }
        private void disminuir_stock()
        {
            Lproductos parametros = new Lproductos();
            Editar_datos funcion = new Editar_datos();
            parametros.Id_Producto1 = idProducto;
            parametros.Stock = txtCantidad.Text;
            if (funcion.disminuir_stock(parametros) == true)
            {
                insertar_KARDEX_SALIDA();
            }
        }
        private void DatalistadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerDatos();
        }
        private void obtenerDatos()
        {
            idProducto = Convert.ToInt32(DatalistadoProductos.SelectedCells[1].Value);
            cantidadActual = Convert.ToDouble(DatalistadoProductos.SelectedCells[6].Value);

            lblcantidadActual.Text = cantidadActual.ToString();
            txtCantidad.Text = "";
            txtcMotivo.Text = "";
            txtBuscarProducto.Text = DatalistadoProductos.SelectedCells[2].Value.ToString();
            DatalistadoProductos.Visible = false;


        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            validaciones();
        }
    }     
}
