using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.PRESENT.CLIENTES_PROVEEDORES
{
    public partial class ClientesOk : Form
    {
        public ClientesOk()
        {
            InitializeComponent();
        }
        int IdProveedor;
        string estado;
        private string querycontar;
        int numClientes;
        private void ClientesOk_Load(object sender, EventArgs e)
        {
            mostrar();
            contar_clientes_activos();
            contar_clientes_Eliminados();
        }
        // crud-----------------------------
        private void insertar()
        {
            Lclientes parametros = new Lclientes();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Nombre = txtnombre.Text;
            parametros.RFC = txtRfc.Text;
            parametros.movil = txtcelular.Text;
            parametros.Direccion_para_factura = txtdireccion.Text;
            if (funcion.insertar_Clientes(parametros) == true) ;
            {
                mostrar();
            }
        }
        private void mostrar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_Clientes(ref dt);
            datalistado.DataSource = dt;
            PANELREGISTRO.Visible = false;
            pintarDatalistado();

        }
        private void editar()
        {
            Lclientes parametros = new Lclientes();
            Editar_datos funcion = new Editar_datos();
            parametros.idclientev = IdProveedor;
            parametros.Nombre = txtnombre.Text;
            parametros.RFC = txtRfc.Text;
            parametros.movil = txtcelular.Text;
            parametros.Direccion_para_factura = txtdireccion.Text;
            if (funcion.editar_Clientes(parametros) == true)
            {
                mostrar();
            }
        }
        private void eliminar()
        {
            try
            {
                Lclientes parametros = new Lclientes();
                Eliminar_datos funcion = new Eliminar_datos();
                parametros.idclientev = IdProveedor;
                if (funcion.eliminar_Clientes(parametros) == true)
                {
                    mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void restaurar()
        {
            Lclientes parametros = new Lclientes();
            Editar_datos funcion = new Editar_datos();
            parametros.idclientev = IdProveedor;
            if (funcion.restaurar_Clientes(parametros) == true)
            {
                mostrar();
            }

        }
        private void buscar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_Clientes(ref dt, txtbusca.Text);
            datalistado.DataSource = dt;
            pintarDatalistado();
        }

        //----------------------------------

        private void pintarDatalistado()
        {
            Bases.Multilinea(ref datalistado);
            datalistado.Columns[2].Visible = false;
            contar_clientes_activos(); 
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                string estado = Convert.ToString(row.Cells["Estado"].Value);
                if (estado == "ELIMINADO")
                {
                    contar_clientes_Eliminados();
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }

        }
        private void rellenarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtcelular.Text)) { txtcelular.Text = "-"; };
            if (string.IsNullOrEmpty(txtdireccion.Text)) { txtdireccion.Text = "-"; };
            if (string.IsNullOrEmpty(txtRfc.Text)) { txtRfc.Text = "-"; };

        }

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

        private void Datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["Editar"].Index)
            {
                obtenerDatos();
            }
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                obtenerId_estado();
                if (estado == "ACTIVO")
                {
                    DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        eliminar();
                    }
                }
            }
        }

        private void obtenerId_estado()
        {
            try
            {
                IdProveedor = Convert.ToInt32(datalistado.SelectedCells[2].Value);
                estado = datalistado.SelectedCells[7].Value.ToString();

            }
            catch (Exception)
            {

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
                        restaurar();
                        prepararEdicion();
                    }

                }
                else
                {
                    prepararEdicion();
                }
            }
            catch (Exception)
            {

            }
        }

        private void prepararEdicion()
        {
            PANELREGISTRO.Visible = true;
            PANELREGISTRO.Dock = DockStyle.Fill;
            btnGuardar.Visible = false;
            btnGuardarCambios.Visible = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = false;
            PANELREGISTRO.Dock = DockStyle.None;
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                rellenarCamposVacios();
                editar();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void contar_clientes_activos()
        {
            Obtener_datos.contar_Clientes_Activos(ref numClientes);
            lblClientesActivos.Text = numClientes.ToString();
        }
        private void contar_clientes_Eliminados()
        {
            Obtener_datos.contar_Clientes_Eliminados(ref numClientes);
            lblClientesEliminados.Text = numClientes.ToString();
        }


    }
}
