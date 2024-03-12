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
            PnResumenVentas.Visible = false;
            pnVentasEmpleado.Visible = false;
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            pnlVentas.Visible = true;
            pnlVentas.Dock = DockStyle.Fill;
            pnlBienvenida.Visible = false;
            pnlProductos.Visible = false;
            pnlCxCobraryPagar.Visible = false;
           //------------------paneles
            pnlFiltros.Enabled = false;
            pnlFechas.Visible = false;
            pnlEmpleados.Visible = false;
            //Botones
            btnVentas.BackColor = Color.FromArgb(0, 85, 128);
            btnVentas.ForeColor = Color.White;
            btnCxC.BackColor = Color.FromArgb(214, 250, 250);
            btnCxC.ForeColor = Color.FromArgb(131, 135, 146);
            btnCxP.BackColor = Color.FromArgb(214, 250, 250);
            btnCxP.ForeColor = Color.FromArgb(131, 135, 146);
            btnProductos.BackColor = Color.FromArgb(214, 250, 250);
            btnProductos.ForeColor = Color.FromArgb(131, 135, 146);
            //Controles Internos
            checkFiltros.Checked = false;
            pnlFechas.Visible = false;
        }

        private void BtnResumenVentas_Click(object sender, EventArgs e)
        {
            PnResumenVentas.Visible = true;
            pnVentasEmpleado.Visible = false;
            pnlFiltros.Visible = true;
            pnlFechas.Enabled = false;
            btnResumenVentas.ForeColor = Color.FromArgb(0, 60, 103);
            pnlEmpleados.Visible = false;
            checkFiltros.Checked = false;
            checkFiltros.ForeColor = Color.FromArgb(0, 60, 103);
            ReporteResumenVentasHoy();
        }
        private void ReporteResumenVentasHoy()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasHoy(ref dt);
            ReporteVentas.resumenVentas rpt = new ReporteVentas.resumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();

        }

        private void BtnHastaHoy_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}
