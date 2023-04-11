using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.MODULOS.VENTAS_MENU_PRINCIPAL
{
    public partial class VENTAS_MENU_PRINCIPALOK : Form
    {
        public VENTAS_MENU_PRINCIPALOK()
        {
            InitializeComponent();
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            CAJA.CIERRE_DE_CAJA frm = new CAJA.CIERRE_DE_CAJA();
            frm.ShowDialog();
        }

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            PRODUCTOS.productosOK frm = new PRODUCTOS.productosOK();
            frm.ShowDialog();
        }

        private void BtnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            CAJA.CIERRE_DE_CAJA frm = new CAJA.CIERRE_DE_CAJA();
            frm.ShowDialog();
        }

        private void Txt_total_suma_Click(object sender, EventArgs e)
        {

        }
    }
}
