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

namespace PUNTO_DE_VENTA.MODULOS.SEREALIZACION_DE_COMPROBANTES
{
    public partial class SEREALIZACION : Form
    {
        public SEREALIZACION()
        {
            InitializeComponent();
        }
        string valor_por_defecto;
        int idserie;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            txtCantidadDeCeros.Clear();
            txtComprobante.Clear();
            txtNumeroFin.Clear();
            txtSerie.Clear();
            checkDefecto.Checked = false;
            checkDefecto.Visible = false;
        }
        private void SEREALIZACION_Load(object sender, EventArgs e)
        {
            Listar();
            panelRegistro.Visible = false;
            panel3.Visible = true;

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serie", txtSerie.Text);
                cmd.Parameters.AddWithValue("@numeroinicio", txtCantidadDeCeros.Text);
                cmd.Parameters.AddWithValue("@numerofin", txtNumeroFin.Text);
                cmd.Parameters.AddWithValue("@Destino", "OTROS");
                cmd.Parameters.AddWithValue("@tipodoc", txtComprobante.Text);
                cmd.Parameters.AddWithValue("@Por_defecto", "-");
                cmd.ExecuteNonQuery();
                con.Close();
                Listar();
                panelRegistro.Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_estos_mismos", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                datalistado.Columns[1].Visible = false;
                datalistado.Columns[2].Visible = false;
                datalistado.Columns[3].Visible = false;
                datalistado.Columns[4].Visible = false;
                datalistado.Columns[5].Width = 220;
                datalistado.Columns[6].Width = 520;
                CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

       

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            ELEJIR_POR_DEFECTO();
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", txtSerie.Text);
                cmd.Parameters.AddWithValue("@Cantidad_de_numeros", txtCantidadDeCeros.Text);
                cmd.Parameters.AddWithValue("@numerofin", txtNumeroFin.Text);
                cmd.Parameters.AddWithValue("@Tipo", txtComprobante.Text);
                cmd.Parameters.AddWithValue("@Id_serie", idserie);
                cmd.ExecuteNonQuery();
                con.Close();
                Listar();
                panelRegistro.Visible = false;
                panel3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void ELEJIR_POR_DEFECTO()
        {
            if (checkDefecto.Checked == true)
            {
                try
                {
                    idserie = Convert.ToInt32(datalistado.SelectedCells[4].Value.ToString());
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_serializacion_POR_DEFECTO", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_serie", idserie);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }


        }

        private void Datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelRegistro.Visible = true;
            try
            {
                txtComprobante.Text = datalistado.SelectedCells[6].Value.ToString();
                txtCantidadDeCeros.Text = datalistado.SelectedCells[2].Value.ToString();
                txtNumeroFin.Text = datalistado.SelectedCells[3].Value.ToString();
                txtSerie.Text = datalistado.SelectedCells[1].Value.ToString();
                btnGuardar.Visible = false;
                btnGuardarCambios.Visible = true;
                valor_por_defecto = datalistado.SelectedCells[7].Value.ToString();
                if (valor_por_defecto == "SI")
                {
                    checkDefecto.Visible = false;
                    checkDefecto.Checked = true;
                }
                else
                {
                    checkDefecto.Visible = true;
                    checkDefecto.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                foreach (DataGridViewRow row in datalistado.SelectedRows)
                {
                    int onekey = Convert.ToInt32(row.Cells["Id_serializacion"].Value);
                    try
                    {

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

                        con.Open();
                        SqlCommand cmd;
                        cmd = new SqlCommand("eliminar_Serializacion", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", onekey);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            Listar();
        }

        private void TxtComprobante_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void TxtComprobante_DoubleClick(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }
    }
}
