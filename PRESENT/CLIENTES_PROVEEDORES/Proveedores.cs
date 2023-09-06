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

namespace PUNTO_DE_VENTA.PRESENT.CLIENTES_PROVEEDORES
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        int IdProveedor;
        string estado;

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void Nuevo()
        {
            PANELREGISTRO.Visible = true;
            Limpiar();
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            btnVolver.Visible = true;
            txtnombre.Focus();
            PANELREGISTRO.Dock = DockStyle.Top;
        }
        private void Limpiar()
        {
            txtnombre.Clear();
            txtcelular.Clear();
            txtdireccion.Clear();
            txtRfc.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                rellenarCamposVacios();
                insertar();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    
        private void insertar()
        {
            LProveedores parametros = new LProveedores();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Nombre = txtnombre.Text;
            parametros.IdentificadorFiscal = txtRfc.Text;
            parametros.Celular = txtcelular.Text;
            parametros.Direccion = txtdireccion.Text;
            if (funcion.insertar_Proveedores(parametros)== true);
            {
                mostrar();
            }
        }
        private void mostrar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_Proveedores(ref dt);
            datalistado.DataSource = dt;
            PANELREGISTRO.Visible = false;


        }
        private void rellenarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtcelular.Text)) { txtcelular.Text = "-"; };
            if (string.IsNullOrEmpty(txtdireccion.Text)) { txtdireccion.Text = "-"; };
            if (string.IsNullOrEmpty(txtRfc.Text)) { txtRfc.Text = "-"; };

        }

        private void Datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["Editar"].Index)
            {
                obtenerDatos();
            }
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                //obtenerId_estado();
                if (estado == "ACTIVO")
                {
                    DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        //eliminar();
                    }
                }

            }
        }

        private void obtenerDatos()
        {
            try
            {
                IdProveedor = Convert.ToInt32(datalistado.SelectedCells[2].Value);
                txtnombre.Text = datalistado.SelectedCells[3].Value.ToString();
                txtdireccion.Text = datalistado.SelectedCells[4].Value.ToString();
                txtRfc.Text = datalistado.SelectedCells[5].Value.ToString();
                txtcelular.Text = datalistado.SelectedCells[6].Value.ToString();
                estado = datalistado.SelectedCells[7].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    DialogResult result = MessageBox.Show("Este Proveedor se Elimino. ¿Desea Volver a Habilitarlo?", "Restaurando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                       
                    }

                }
                else
                {
                    PANELREGISTRO.Visible = true;
                    PANELREGISTRO.Dock = DockStyle.Fill;
                }
            }
            catch (Exception)
            {

            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
