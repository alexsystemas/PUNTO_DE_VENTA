using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.PRESENT.REPORTES
{
    public partial class menuReportes : Form
    {
        public menuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {
            pnlBienvenida.Visible = true;
            pnlBienvenida.Dock = DockStyle.Fill;
        }
    }
}
