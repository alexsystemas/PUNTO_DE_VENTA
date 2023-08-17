using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PUNTO_DE_VENTA.sevendePor.CLIENTES_PROVEEDORES
{
    public partial class clientes : Form
    {
        int id;
        string estado;
        public clientes()
        {
            InitializeComponent();
        }
        private void limpiar()
        {

            txtnombrecliente.Clear();
            txtrucdefactura.Clear();
            txtcelular.Clear();
            txtdirecciondefactura.Clear();
            txtnombrecliente.Focus();
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtnombrecliente.Text != "")
            {

                if (txtdirecciondefactura.Text == "")
                {
                    txtdirecciondefactura.Text = "0";
                }
                if (txtrucdefactura.Text == "")
                {
                    txtrucdefactura.Text = "0";
                }
                if (txtcelular.Text == "")
                {
                    txtcelular.Text = "0";
                }
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtnombrecliente.Text);
                    cmd.Parameters.AddWithValue("@Direccion_para_factura", txtdirecciondefactura.Text);
                    cmd.Parameters.AddWithValue("@RFC", txtrucdefactura.Text);
                    cmd.Parameters.AddWithValue("@movil", txtcelular.Text);
                    cmd.Parameters.AddWithValue("@Cliente", "SI");
                    cmd.Parameters.AddWithValue("@Proveedor", "NO");
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                    cmd.Parameters.AddWithValue("@Saldo", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtbusca.Text = txtnombrecliente.Text;
                    buscar();
                    PANELREGISTRO.Visible = false;
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Llenar campo Nombre", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = true;
            limpiar();
            PANELREGISTRO.Dock = DockStyle.Fill;
            txtbusca.Clear();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void mostrar()
        {
            try
            {


                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_cliente", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);
            Cambiar_color_para_registros_eliminados();
            contar_clientes_activos();
            contar_clientes_ELIMINADOS();

        }

        private void contar_clientes_activos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand com = new SqlCommand("contar_clientes_activos", con);
            try
            {
                con.Open();
                lblClienetesActivos.Text = Convert.ToString(com.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


        }

        private void contar_clientes_ELIMINADOS()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand com = new SqlCommand("contar_clientes_eliminados", con);
            try
            {
                con.Open();
                lblClienetesEliminados.Text = Convert.ToString(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
       

        private void Datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in datalistado.SelectedRows)
                    {
                        try
                        {
                            int Idcliente = Convert.ToInt32(row.Cells["idclientev"].Value);
                            SqlCommand cmd;
                            SqlConnection con = new SqlConnection();
                            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                            con.Open();
                            cmd = new SqlCommand("eliminar_cliente", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idcliente", Idcliente);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.StackTrace);
                        }
                        mostrar();
                    }
                }
            }

            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                Proceso_para_obtener_datos();
            }
        }

        private void Proceso_para_obtener_datos()
        {
            try
            {
                estado = datalistado.SelectedCells[10].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    restaurar();
                }
                else
                {
                    id = Convert.ToInt32(datalistado.SelectedCells[2].Value.ToString());
                    txtnombrecliente.Text = datalistado.SelectedCells[3].Value.ToString();
                    txtdirecciondefactura.Text = datalistado.SelectedCells[4].Value.ToString();
                    txtrucdefactura.Text = datalistado.SelectedCells[5].Value.ToString();
                    txtcelular.Text = datalistado.SelectedCells[6].Value.ToString();
                    PANELREGISTRO.Visible = true;
                    //  btnGuardarCambios.Visible = true;
                    btnGuardar.Visible = false;
                    PANELREGISTRO.Dock = DockStyle.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void restaurar()
        {
            DialogResult result;
            result = MessageBox.Show("Este cliente se Elimino, ¿Desea volver a Habilitarlo?", "Restaurancion de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datalistado.SelectedRows)
                {
                    int idcliente = Convert.ToInt32(row.Cells["idclientev"].Value);
                    try
                    {
                        SqlCommand cmd;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                        con.Open();
                        cmd = new SqlCommand("restaurar_cliente", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idcliente", idcliente);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                    mostrar();
                }
            }
        }

        private void Datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Proceso_para_obtener_datos();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = false;
        }

        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }



        private void buscar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_cliente_Form", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbusca.Text);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);
            Cambiar_color_para_registros_eliminados();
            contar_clientes_activos();
            contar_clientes_ELIMINADOS();
        }
        private void Cambiar_color_para_registros_eliminados()
        {
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                if (row.Cells["Estado"].Value.ToString() == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void ocultar_columnas()
        {
            datalistado.Columns[2].Visible = false;
            datalistado.Columns[3].Width = 400;
            datalistado.Columns[4].Width = 250;
        }

      

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {

            if (txtnombrecliente.Text != "")
            {

                if (txtdirecciondefactura.Text == "")
                {
                    txtdirecciondefactura.Text = "0";
                }
                if (txtrucdefactura.Text == "")
                {
                    txtrucdefactura.Text = "0";
                }
                if (txtcelular.Text == "")
                {
                    txtcelular.Text = "0";
                }
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcliente", id);
                    cmd.Parameters.AddWithValue("@Nombre", txtnombrecliente.Text);
                    cmd.Parameters.AddWithValue("@Direccion_para_factura", txtdirecciondefactura.Text);
                    cmd.Parameters.AddWithValue("@RFC", txtrucdefactura.Text);
                    cmd.Parameters.AddWithValue("@movil", txtcelular.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtbusca.Text = txtnombrecliente.Text;
                    buscar();
                    PANELREGISTRO.Visible = false;
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Llenar campo Nombre", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

       
    }
}

