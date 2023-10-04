using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.PRESENT.CAJA;

namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    public partial class CierreTurno : Form
    {
        public CierreTurno()
        {
            InitializeComponent();
        }
        string correobase;
        string contraseña;
        string estado;
        double dinerocalculado;
        double resultado;
        string correoReceptor;
        double dineroCalculado;
        private void CierreTurno_Load(object sender, EventArgs e)
        {
            lbldeberiaHaber.Text = lblVentasTotal.dineroEnCaja.ToString();
            dineroCalculado = Convert.ToDouble(lbldeberiaHaber.Text);
        }

        private void validacionesCalculo()
        {
            if (resultado == 0)
            {
                lblanuncio.Text = "Genial, Todo esta perfecto";
                lblanuncio.ForeColor = Color.FromArgb(0, 166, 63);
                lbldiferencia.ForeColor = Color.FromArgb(0, 166, 63);
                lblanuncio.Visible = true;

            }
            if (resultado < dinerocalculado & resultado != 0)
            {
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67);
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67);
                lblanuncio.Visible = true;

            }
            if (resultado > dinerocalculado)
            {
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67);
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67);
                lblanuncio.Visible = true;
            }
        }
        private void calcular()
        {
            try
            {
                double hay;
                hay = Convert.ToDouble(txtHay.Text);
                if (string.IsNullOrEmpty(txtHay.Text))
                {
                    hay = 0;
                }
                resultado = hay - dinerocalculado;
                lbldiferencia.Text = resultado.ToString();
                validacionesCalculo();
            }
            catch (Exception)
            {


            }
        }

        private void TxtHay_Click(object sender, EventArgs e)
        {

        }

        private void TxtHay_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
