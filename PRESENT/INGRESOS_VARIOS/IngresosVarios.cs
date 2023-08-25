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
namespace PUNTO_DE_VENTA.PRESENT.INGRESOS_VARIOS
{
    public partial class IngresosVarios : Form
    {
        public IngresosVarios()
        {
            InitializeComponent();
        }
        int idcaja;
        private void rellenar_campos_vacios()
        {
            if (string.IsNullOrEmpty(txtDetalle.Text)) { txtDetalle.Text = "Sin detallar"; }
            if (string.IsNullOrEmpty(txtNroComprobante.Text)) { txtNroComprobante.Text = "-"; }
            if (string.IsNullOrEmpty(txtTipo_de_comprobante.Text)) { txtTipo_de_comprobante.Text = "-"; }
        }
        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            rellenar_campos_vacios();
            bool estado = Insertar_datos.insertar_Ingresos_varios(txtfecha.Value, txtNroComprobante.Text,
                   txtTipo_de_comprobante.Text, Convert.ToDouble(txtImporte.Text), txtDetalle.Text,
            idcaja);
            if (estado == true)
            {

                limpiar_inicio();
                MessageBox.Show("Datos ingresados correctamente", "Registros exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void limpiar_inicio()
        {
           
            chSinConprobante.Checked = true;
            pnlComprobantes.Visible = false;
            txtImporte.Clear();
            txtDetalle.Clear();
            txtNroComprobante.Clear();
        }
        private void IngresosVarios_Load(object sender, EventArgs e)
        {
            limpiar_inicio();
            Obtener_datos.obtener_id_caja_PorSerial(ref idcaja);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
