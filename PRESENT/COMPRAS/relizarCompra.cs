﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.PRESENT.CLIENTES_PROVEEDORES;

namespace PUNTO_DE_VENTA.PRESENT.COMPRAS
{
    public partial class relizarCompra : UserControl
    {
        public relizarCompra()
        {
            InitializeComponent();
        }
        string estadocompra;
        int idproducto;
        Panel panel_mostrador_de_productos = new Panel();
        string tipo_de_busqueda;
        int idcompra = 0;
        int idproveedor;
        string seveendepor;
        double txtpantalla;
        int iddetallecompra;
        string sevendePor;
        bool SECUENCIA = true;
        

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                ocultar_mostrar_productos();
            }
            else
            {
                mostrar_productos();
            }
            buscar_productos();
        }
        private void buscar_productos()
        {
            var dt = new DataTable();
            var funcion = new Dproductos();
            funcion.buscarProductos(ref dt, txtbuscar.Text);
            dgProducctos.DataSource = dt;
            dgProducctos.Columns[0].Visible = false;
            dgProducctos.Columns[1].Visible = false;
            dgProducctos.Columns[2].Width = 600;
            dgProducctos.Columns[3].Visible = false;
            dgProducctos.Columns[4].Visible = false;
            dgProducctos.Columns[5].Visible = false;
            dgProducctos.Columns[6].Visible = false;
            dgProducctos.Columns[7].Visible = false;
            dgProducctos.Columns[8].Visible = false;
            dgProducctos.Columns[9].Visible = false;
            dgProducctos.Columns[10].Visible = false;
        }
        private void mostrar_productos()
        {
            panel_mostrador_de_productos.Size = new Size(600, 186);
            panel_mostrador_de_productos.BackColor = Color.White;
            panel_mostrador_de_productos.Location = new Point(panelReferencia.Location.X, panelReferencia.Location.Y);
            panel_mostrador_de_productos.Visible = true;
            dgProducctos.Visible = true;
            dgProducctos.Dock = DockStyle.Fill;
            dgProducctos.BackgroundColor = Color.White;
            lbltipodebusqueda2.Visible = false;
            panel_mostrador_de_productos.Controls.Add(dgProducctos);
            this.Controls.Add(panel_mostrador_de_productos);
            panel_mostrador_de_productos.BringToFront();
        }
        private void ocultar_mostrar_productos()
        {
            panel_mostrador_de_productos.Visible = false;
            dgProducctos.Visible = false;
            lbltipodebusqueda2.Visible = true;
        }
        private void RelizarCompra_Load(object sender, EventArgs e)
        {
            estadocompra = "COMPRA NUEVA";
            dibujar_proveedores();
            eliminarComprasvacias();


        }
        private void dibujar_proveedores()
        {
            var funcion = new Dproveedores();
            DataTable dt = new DataTable();
            funcion.buscar_proveedores(ref dt, txtBuscarProveedor.Text);
            flowPanelProveedor.Controls.Clear();
            foreach (DataRow rdr in dt.Rows)
            {
                Button b = new Button();
                b.Size = new Size(149, 65);
                b.Text = rdr["Nombre"].ToString();
                b.Name = rdr["IdProveedor"].ToString();
                b.BackColor = Color.FromArgb(43, 43, 43);
                b.Font = new Font("Microsoft Sans Serif", 12);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.ForeColor = Color.White;
                flowPanelProveedor.Controls.Add(b);
                b.Click += B_Click;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            idproveedor = Convert.ToInt32(((Button)sender).Name);
            // deseleccionar button 
            foreach (Button b in flowPanelProveedor.Controls)
            {
                if (b is Button)
                {
                    b.BackColor = Color.FromArgb(43, 43, 43);
                }
            }
            //seleccionar button 
            foreach (Button b2 in flowPanelProveedor.Controls)
            {
                if (b2 is Button)
                {
                    if (b2.Name == idproveedor.ToString())
                    {
                        b2.BackColor = Color.FromArgb(0, 60, 103);
                    }

                }
            }
        }






        private void BtnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            lbltipodebusqueda2.Visible = false;
        }

        private void TxtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            dibujar_proveedores();
        }

        private void DgProducctos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbuscar.Text = dgProducctos.SelectedCells[9].Value.ToString();

            idproducto = Convert.ToInt32(dgProducctos.SelectedCells[1].Value);

            panel_mostrador_de_productos.Visible = false;
            insertar_compra();
        }

        private void insertar_compra()
        {
            var funcion = new Dcompras();
            var parametros = new LDetalleCompra();
            parametros.Estado = estadocompra;
            parametros.Cantidad = 1;
            parametros.Costo = 1;
            parametros.Moneda = "-";
            parametros.Descripcion = txtbuscar.Text;
            parametros.IdProducto = idproducto;
            if (funcion.Insertar_Compras(parametros) == true)
            {
                estadocompra = "COMPRA GENERADA";
                mostar_ultimoIdCompra();
                mostrarDetalleCompra();
            }


        }

        private void eliminarComprasvacias()
        {
            var funcion = new Dcompras();
            funcion.eliminarComprasvacias();

        }

        private void mostar_ultimoIdCompra()
        {
            var funcion = new Dcompras();
            funcion.MostrarUltimoIdcompra(ref idcompra);
        }

        private void mostrarDetalleCompra()
        {
            var dt = new DataTable();
            var funcion = new DdetalleCompra();
            var parametros = new LDetalleCompra();
            parametros.IdCompra = idcompra;
            funcion.mostrar_DetalleCompra(ref dt, parametros);
            dgDetalleCompra.DataSource = dt;
            dgDetalleCompra.Columns[1].Visible = false;
            dgDetalleCompra.Columns[2].Visible = false;
            dgDetalleCompra.Columns[3].Visible = false;
            dgDetalleCompra.Columns[8].Visible = false;
            dgDetalleCompra.Columns[9].Visible = false;
            Bases.Multilinea(ref dgProducctos);
            sumar();
        }

        private void sumar()
        {
            try
            {
                int x;
                x = dgDetalleCompra.Rows.Count;
                if (x == 0)
                {
                    txt_total_suma.Text = "0.00";
                }
                double totalpagar;
                totalpagar = 0;
                foreach (DataGridViewRow fila in dgDetalleCompra.Rows)
                {
                    totalpagar += Convert.ToDouble(fila.Cells["Total"].Value);
                    txt_total_suma.Text = totalpagar.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DgDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iddetallecompra = Convert.ToInt32(dgDetalleCompra.SelectedCells[1].Value);
            idproducto = Convert.ToInt32(dgDetalleCompra.SelectedCells[3].Value);
            sevendePor = (dgDetalleCompra.SelectedCells[8].Value.ToString());
            if (e.ColumnIndex == dgDetalleCompra.Columns["EL"].Index)
            {
                eliminar_detalle_compra();
            }
        }

        private void eliminar_detalle_compra()
        {
            var funcion = new DdetalleCompra();
            var parametros = new LDetalleCompra();
            parametros.IdDetallecompra = iddetallecompra;
            funcion.eliminar_detalle_compra(parametros);
            mostrarDetalleCompra();

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

        private void Btnborrartodo_Click(object sender, EventArgs e)
        {
            txtmonto.Clear();
            SECUENCIA = true;
        }

        private void BtnSeparador_Click(object sender, EventArgs e)
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

        private void Txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtmonto, e);
        }

        private void BtnCantidad_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                if (dgDetalleCompra.RowCount > 0)
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
                    else
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
            txtpantalla = Convert.ToDouble(txtmonto.Text);
            double Cantidad;
            Cantidad = Convert.ToDouble(dgDetalleCompra.SelectedCells[5].Value);
            string ControlStock;
            ControlStock = dgDetalleCompra.SelectedCells[9].Value.ToString();
            if (ControlStock == "SI")
            {
                editar_detalle_compra_Cantidad();
                txtmonto.Clear();
            }

        }
        private void editar_detalle_compra_Cantidad()
        {
            var funcion = new DdetalleCompra();
            var parametros = new LDetalleCompra();
            parametros.IdCompra = idcompra;
            parametros.IdProducto = idproducto;
            parametros.Cantidad = txtpantalla;
            funcion.editar_detalle_compra_Cantidad(parametros);
            mostrarDetalleCompra();

        }
        private void BtnPrecio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                editar_detalle_compra_Precio();
            }
            else
            {
                txtmonto.Clear();
                txtmonto.Focus();
            }
        }

       
        private void editar_detalle_compra_Precio()
        {
            txtpantalla = Convert.ToDouble(txtmonto.Text);
            var funcion = new DdetalleCompra();
            var parametros = new LDetalleCompra();
            parametros.IdCompra = idcompra;
            parametros.IdProducto = idproducto;
            parametros.Costo = txtpantalla;
            funcion.editar_detalle_compra_Precio(parametros);
            mostrarDetalleCompra();
            txtmonto.Clear();

        }

        private void insertarKardex()
        {
            var parametros = new LKardex();
            var funcion = new DKardex();
            parametros.Fecha = DateTime.Now;
            parametros.Motivo = "COMPRAS";
            foreach (DataGridViewRow rdr in dgDetalleCompra.Rows)
            {
                double cantidad = Convert.ToDouble(rdr.Cells["Cantidad"].Value);
                int idproducto = Convert.ToInt32(rdr.Cells["Id_Producto1"].Value);
                parametros.Cantidad = cantidad;
                parametros.Id_producto = idproducto;
                funcion.insertar_KARDEX_Entrada(parametros);

            }

        }
        private void insertarStock()
        {
            var parametros = new Lproductos();
            var funcion = new Dproductos();
            foreach (DataGridViewRow rdr in dgDetalleCompra.Rows)
            {
                double cantidad = Convert.ToDouble(rdr.Cells["Cantidad"].Value);
                int idproducto = Convert.ToInt32(rdr.Cells["Id_Producto1"].Value);
                parametros.Stock = cantidad.ToString();
                parametros.Id_Producto1 = idproducto;
                funcion.aumentarStock(parametros);

            }

        }

        private void Txtbuscar_Click(object sender, EventArgs e)
        {
            txtbuscar.SelectAll();
        }

        private void BtnAgregarPro_Click(object sender, EventArgs e)
        {
            var frm = new Proveedores();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dibujar_proveedores();
        }
        private void BtnComprar_Click(object sender, EventArgs e)
        {

            confirmarCompra();
        }
        private void confirmarCompra()
        {
            var funcion = new Dcompras();
            var parametros = new Lcompras();
            parametros.Idcompra = idcompra;
            parametros.Total = Convert.ToDouble(txt_total_suma.Text);
            parametros.IdProveedor = idproveedor;
            if (funcion.confirmarCompra(parametros) == true)
            {
                insertarKardex();
                insertarStock();
                MessageBox.Show("Compra realizada correctamente");
                Limpiar();
            }

        }
        private void Limpiar()
        {
            txtmonto.Clear();
            txtbuscar.Clear();
            idcompra = 0;
            mostrarDetalleCompra();
            estadocompra = "COMPRA NUEVA";
        }
    }
}
