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

namespace PUNTO_DE_VENTA.PRESENT.APERTURA_DE_CREDITO
{
    public partial class PorPagar : Form
    {
        public PorPagar()
        {
            InitializeComponent();
        }
        int idProveedor;
        Panel p = new Panel();
        //crud-----------------
        private void buscar_Proveedores()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_Proveedores(ref dt, txtProveedor.Text);
            datalistado.DataSource = dt;
            datalistado.Columns[1].Visible = false;
            datalistado.Columns[3].Visible = false;
            datalistado.Columns[4].Visible = false;
            datalistado.Columns[5].Visible = false;
            datalistado.Columns[6].Visible = false;
            dibujar_panel();
        }
        private void insertarCreditos()
        {
            LcreditosPorPagar parametros = new LcreditosPorPagar();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Descripcion = txtDetalle.Text;
            parametros.Fecha_registro = txtFechaRegistro.Value;
            parametros.Fecha_vencimiento = txtFechaVencimiento.Value;
            parametros.Total = Convert.ToDouble(txtSaldo.Text);
            parametros.Saldo = Convert.ToDouble(txtSaldo.Text);
            parametros.Id_proveedor = idProveedor;
            if (funcion.insertar_CreditoPorPagar(parametros) == true)
            {
                MessageBox.Show("Registrado");
                limpiar();
                buscar_Proveedores();
                

            }

        }
        //----------------------

        private void dibujar_panel()
        {
            datalistado.Dock = DockStyle.Fill;
            datalistado.Visible = true;
            p.Controls.Add(datalistado);
            p.Location = new Point(pnlCordenadas.Location.X, pnlCordenadas.Location.Y + pnl_Proveedor.Location.Y);
            p.Size = new System.Drawing.Size(400, 102);
            Controls.Add(p);
            p.BringToFront();

        }

        private void limpiar()
        {
            txtSaldo.Clear();
            txtDetalle.Clear();
            idProveedor = 0;
            txtProveedor.Clear();

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSaldo.Text))
            {
                rellenarCamosVacios();
                insertarCreditos();
            }
            else
            {
                MessageBox.Show("ingresa un saldo");
            }
        }

        private void rellenarCamosVacios()
        {
            if (string.IsNullOrEmpty(txtDetalle.Text)) { txtDetalle.Text = "-"; }
        }
      

        private void TxtProveedor_TextChanged(object sender, EventArgs e)
        {
            txtProveedor.SelectAll();
            buscar_Proveedores();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CLIENTES_PROVEEDORES.Proveedores frm = new CLIENTES_PROVEEDORES.Proveedores();
            frm.ShowDialog();
        }

        private void PorPagar_Load(object sender, EventArgs e)
        {
            buscar_Proveedores();
        }

        private void Datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProveedor = Convert.ToInt32(datalistado.SelectedCells[1].Value);
            txtProveedor.Text = datalistado.SelectedCells[2].Value.ToString();
            Controls.Remove(p);
        }

        private void Datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
