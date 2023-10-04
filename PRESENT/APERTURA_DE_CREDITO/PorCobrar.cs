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
    public partial class PorCobrar : Form
    {
        public PorCobrar()
        {
            InitializeComponent();
        }
        int idCliente;
        Panel p = new Panel();
        private void PorCobrar_Load(object sender, EventArgs e)
        {
            buscar_Clientes();
        }
        //crud-----------------
        private void buscar_Clientes()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_Clientes(ref dt, txtCliente.Text);
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
            LcreditoPorCobrar parametros = new LcreditoPorCobrar();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Descripcion = txtDetalle.Text;
            parametros.Fecha_registro = txtFechaRegistro.Value;
            parametros.Fecha_vencimiento = txtFechaVencimiento.Value;
            parametros.Total = Convert.ToDouble(txtSaldo.Text);
            parametros.Saldo = Convert.ToDouble(txtSaldo.Text);
            parametros.Id_cliente = idCliente;
            if (funcion.insertar_CreditoPorCobrar(parametros) == true)
            {
                MessageBox.Show("Registrado");
                limpiar();
                buscar_Clientes();


            }

        }
        //----------------------

        private void dibujar_panel()
        {
            datalistado.Dock = DockStyle.Fill;
            datalistado.Visible = true;
            p.Controls.Add(datalistado);
            p.Location = new Point(pnlCordenadas.Location.X, pnlCordenadas.Location.Y + pnl_Proveedor.Location.Y);
            p.Size = new System.Drawing.Size(404, 239);
            Controls.Add(p);
            p.BringToFront();

        }

        private void limpiar()
        {
            txtSaldo.Clear();
            txtDetalle.Clear();
            idCliente = 0;
            txtCliente.Clear();

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            CLIENTES_PROVEEDORES.ClientesOk frm = new CLIENTES_PROVEEDORES.ClientesOk();
            frm.ShowDialog();
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            txtCliente.SelectAll();
            buscar_Clientes();
        }

        private void Datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt32(datalistado.SelectedCells[1].Value);
            txtCliente.Text = datalistado.SelectedCells[2].Value.ToString();
            Controls.Remove(p);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSaldo.Text))
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
    }
}
