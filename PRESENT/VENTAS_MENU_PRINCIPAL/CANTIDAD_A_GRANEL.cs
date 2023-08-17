using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.PRESENT.VENTAS_MENU_PRINCIPAL
{
    public partial class CANTIDAD_A_GRANEL : Form
    {
        public CANTIDAD_A_GRANEL()
        {
            InitializeComponent();
        }
        public  double preciounitario;
        private void CANTIDAD_A_GRANEL_Load(object sender, EventArgs e)
        {
            txtprecio_unitario.Text = Convert.ToString(preciounitario);
        }
        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void calcularTotal()
        {
            try
            {
                double total;
                double cantidad;
                cantidad = Convert.ToDouble(txtCantidad.Text);
                total = preciounitario * cantidad;
                txtTotal.Text = Convert.ToString(total);
            }
            catch (Exception)
            {

              
            }
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            VENTAS_MENU_PRINCIPALOK.txtpantalla=Convert.ToDouble( txtCantidad.Text);
            Dispose();
        }
    }
}
