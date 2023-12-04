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



namespace PUNTO_DE_VENTA.PRESENT.COBROS
{
    public partial class CobrosForm : Form
    {
        public CobrosForm()
        {
            InitializeComponent();
        }
        public static int idcliente;
        public static double saldo;

        private void TxtClienteSolicitante_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_Clientes(ref dt, txtClienteSolicitante.Text);
            datalistadoClientes.DataSource = dt;
            datalistadoClientes.Columns[1].Visible = false;
            datalistadoClientes.Columns[3].Visible = false;
            datalistadoClientes.Columns[4].Visible = false;
            datalistadoClientes.Columns[5].Visible = false;
            datalistadoClientes.Columns[6].Visible = false;
            datalistadoClientes.Columns[7].Visible = false;
            datalistadoClientes.Columns[2].Width = datalistadoClientes.Width;
            datalistadoClientes.BringToFront();
            datalistadoClientes.Visible = true;
            datalistadoClientes.Location = new Point(pnlregistros.Location.X, pnlregistros.Location.Y);
            datalistadoClientes.Size = new Size(400, 161);
            pnlregistros.Visible = false;

        }

   

        private void DatalistadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            idcliente =(int) datalistadoClientes.SelectedCells[1].Value;
            txtClienteSolicitante.Text = datalistadoClientes.SelectedCells[2].Value.ToString();
            obtenerSaldo();
            datalistadoClientes.Visible = false;
            pnlregistros.Visible = true;
            mostrarEstadosCuentaCliente();
        }
        private void obtenerSaldo()
        {
            txtTotal_Saldo.Text = datalistadoClientes.SelectedCells[7].Value.ToString();
            saldo = Convert.ToDouble(datalistadoClientes.SelectedCells[7].Value);
        }
        private void mostrarEstadosCuentaCliente()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarEstadosCuentaCliente(ref dt, idcliente);
            dataListadoHitorial.DataSource = dt;
            Bases.Multilinea(ref dataListadoHitorial);
            pnlH.Visible = true;
            pnlM.Visible = false;
            pnlHistorial.Visible = true;
            pnlHistorial.Dock = DockStyle.Fill;

            pnlMovimientos.Visible = false;
            pnlMovimientos.Dock = DockStyle.None;


        }

        private void BtnMovimientos_Click(object sender, EventArgs e)
        {
            mostrarControlCobros();
        }
        private void mostrarControlCobros()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_ControlCobros(ref dt);
            datalistadoMovimientos.DataSource = dt;
            Bases.Multilinea(ref datalistadoMovimientos);
            // Bases estilo = new Bases();
            //estilo.(ref datalistadoMovimientos);
            datalistadoMovimientos.Columns[1].Visible = false;
            datalistadoMovimientos.Columns[5].Visible = false;
            datalistadoMovimientos.Columns[6].Visible = false;
            datalistadoMovimientos.Columns[7].Visible = false;

            pnlH.Visible = false;
            pnlM.Visible = true;
            pnlHistorial.Visible = false;
            pnlMovimientos.Visible = true;
            pnlMovimientos.Dock = DockStyle.Fill;
            pnlHistorial.Dock = DockStyle.None;
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            mostrarEstadosCuentaCliente();
        }

        private void BtnAbonar_Click(object sender, EventArgs e)
        {
            if(saldo>0)
            {
                COBROS.MediosCobros frm = new COBROS.MediosCobros();
                frm.FormClosing += Frm_FormClosing;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("El saldo del cliente actual es 0");
            }
           
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            buscar();
            obtenerSaldo();
            mostrarEstadosCuentaCliente();
        }

        private void TxtClienteSolicitante_Click(object sender, EventArgs e)
        {
            txtClienteSolicitante.SelectAll();
        }

        private void DatalistadoMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==datalistadoMovimientos.Columns["Eli"].Index)
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Abono?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result==DialogResult.OK)
                {
                    aumentarSaldo();
                }
            }
        }
        private void aumentarSaldo()
        {
            double monto;
            monto =Convert.ToDouble( datalistadoMovimientos.SelectedCells[2].Value);
            Lclientes parametros = new Lclientes();
            Editar_datos funcion = new Editar_datos();
            parametros.idclientev = idcliente;
            funcion.aumentarSaldocliente(parametros, monto);
            if(funcion.aumentarSaldocliente(parametros,monto)==true)
            {
                eliminarControlCobros();
            }
        }
        private void eliminarControlCobros()
        {
            LcontrolCobros parametros = new LcontrolCobros();
            Eliminar_datos funcion = new Eliminar_datos();
            parametros.idcontrolCobro = Convert.ToInt32(datalistadoMovimientos.SelectedCells[1].Value);
            if(funcion.eliminarControlCobro(parametros)==true)
            {
                buscar();
            }
        }
    }
}
