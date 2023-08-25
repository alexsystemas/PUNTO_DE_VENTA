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
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;
namespace PUNTO_DE_VENTA.PRESENT.GASTOS_VARIOS
{
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }
        int idConcepto;
        int idcaja;
        private void BtnGuardarConceptos_Click(object sender, EventArgs e)
        {
            Insertar_datos.insertar_Conceptos(txtDescripcion.Text);
            buscador_de_conceptos();
            pnlConceptos.Visible = false;
            pnlConceptos.Dock = DockStyle.None;
        }
        private void buscador_de_conceptos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_conceptos(ref dt, txtBuscarConcepto.Text);
            datalistado_conceptos.DataSource = dt;
            datalistado_conceptos.Columns[1].Visible = false;
            Bases.Multilinea(ref datalistado_conceptos);
        }

        private void BtnNuevoConcepto_Click(object sender, EventArgs e)
        {
            mostrar_panelconceptos(); ;
            pnlConceptos.Visible = true;
            pnlConceptos.Dock = DockStyle.Fill;
            pnlConceptos.BringToFront();

            btnGuardarConceptos.Visible = true;
            btnGuardarCambiosConceptos.Visible = false;
            txtDescripcion.Clear();
        }
        private void mostrar_panelconceptos()
        {
            pnlConceptos.Visible = true;
            pnlConceptos.Dock = DockStyle.Fill;
            pnlConceptos.BringToFront();
        }
        private void limpiar_inicio()
        {
            pnlConceptos.Visible = false;
            pnlConceptos.Dock = DockStyle.None;
            txtDescripcion.Clear();
            txtBuscarConcepto.Clear();
            mostrar_datalistadoConceptos();
            this.Size = new System.Drawing.Size(557, 409);
            chSinConprobante.Checked = true;
            pnlComprobantes.Visible = false;
            txtImporte.Clear();
            txtDetalle.Clear();
            txtNroComprobante.Clear();
        }
        private void mostrar_datalistadoConceptos()
        {
            datalistado_conceptos.Visible = true;
            datalistado_conceptos.Location = new Point(pnlDetalle.Location.X, pnlDetalle.Location.Y);
            datalistado_conceptos.Size = new System.Drawing.Size(557, 409);
            datalistado_conceptos.BringToFront();
            buscador_de_conceptos();

        }
        private void TxtConcepto_TextChanged(object sender, EventArgs e)
        {
            buscador_de_conceptos();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            limpiar_inicio();
            Obtener_datos.obtener_id_caja_PorSerial(ref idcaja);
        }

        private void Datalistado_conceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idConcepto = Convert.ToInt32(datalistado_conceptos.SelectedCells[1].Value);
                txtBuscarConcepto.Text = datalistado_conceptos.SelectedCells[2].Value.ToString();
                datalistado_conceptos.Visible = false;
                if(e.ColumnIndex==datalistado_conceptos.Columns["Editar"].Index)
                {
                    mostrar_panelconceptos();
                    btnGuardarCambiosConceptos.Visible = true;
                    btnGuardarConceptos.Visible = false;
                    txtDescripcion.Text = txtBuscarConcepto.Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

     
        private void rellenar_campos_vacios()
        {
            if (string.IsNullOrEmpty(txtDetalle.Text)) { txtDetalle.Text = "Sin detallar"; }
            if (string.IsNullOrEmpty(txtNroComprobante.Text)) { txtNroComprobante.Text = "-"; }
            if (string.IsNullOrEmpty(txtTipo_de_comprobante.Text)) { txtTipo_de_comprobante.Text = "-"; }
        }
        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            rellenar_campos_vacios();
            Insertar_datos.insertar_Gastos_varios(txtfecha.Value, txtNroComprobante.Text,
            txtTipo_de_comprobante.Text, Convert.ToDouble(txtImporte.Text), txtDetalle.Text,
            idcaja, idConcepto);
            limpiar_inicio();

        }

        private void ChSinConprobante_CheckedChanged(object sender, EventArgs e)
        {
            if (chSinConprobante.Checked == true)
            {
                pnlComprobantes.Visible = false;
            }
            else
            {
                pnlComprobantes.Visible = true;
            }
        }

        private void TxtConcepto_Click(object sender, EventArgs e)
        {
            txtBuscarConcepto.SelectAll();
            mostrar_datalistadoConceptos();
        }
    }
}


