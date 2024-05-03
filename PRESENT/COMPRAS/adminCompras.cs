using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.PRESENT.COMPRAS
{
    public partial class adminCompras : Form
    {
        public adminCompras()
        {
            InitializeComponent();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            pnlVisor.Controls.Clear();
            var frm = new relizarCompra();
            frm.Dock = DockStyle.Fill;
            pnlVisor.Controls.Add(frm);
            frm.Show();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            pnlVisor.Controls.Clear();
            var frm = new HistorialCompras();
            frm.Dock = DockStyle.Fill;
            pnlVisor.Controls.Add(frm);
            frm.Show();
        }
    }
}
