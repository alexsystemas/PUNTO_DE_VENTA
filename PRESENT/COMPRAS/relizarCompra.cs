using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.DATE;

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
        int idcompra=0;
        int idproveedor;
        string seveendepor;
        double txtpantalla;
        int iddetallecompra;

        private void RelizarCompra_Load(object sender, EventArgs e)
        {
            ocultar_mostrar_productos();
            estadocompra = "COMPRA NUEVA";
            dibujar_proveedores();

        }
        private void dibujar_proveedores()
        {
            var funcion = new Dproveedores();
            DataTable dt = new DataTable();
            funcion.buscar_proveedores(ref dt, txtBuscarProveedor.Text);
            flowPanelProveedor.Controls.Clear();
            foreach(DataRow rdr in dt.Rows)
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
            foreach(Button b in flowPanelProveedor.Controls)
            {
                if(b is Button)
                {
                    b.BackColor = Color.FromArgb(43,43,43);
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

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
          if( txtbuscar.Text=="")
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

        private void BtnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            lbltipodebusqueda2.Visible = false;
        }

        private void TxtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            dibujar_proveedores();
        }
    }
}
