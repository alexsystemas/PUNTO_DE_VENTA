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
        int idUsuario;
        private void MenuReportes_Load(object sender, EventArgs e)
        {
            pnlBienvenida.Visible = true;
            pnlBienvenida.Dock = DockStyle.Fill;
            PnResumenVentas.Visible = false;
            pnVentasEmpleado.Visible = false;
            pnlProductos.Visible = false;
            pnlFiltros.Visible = false;
            btnHastaHoy.ForeColor = Color.OrangeRed;

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            pnlVentas.Visible = true;
            pnlVentas.Dock = DockStyle.Fill;
            pnlBienvenida.Visible = false;
            reportCobrar_Y_Pagar.Visible = false;
            //------------------paneles
            pnlFechas.Enabled = false;
            pnlFechas.Visible = false;
            pnlEmpleados.Visible = false;
            pnlProductos.Visible = false;
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
            btnHastaHoy.ForeColor = Color.OrangeRed;
            ReporteResumenVentasHoy();
        }
        private void ReporteResumenVentasHoyEmpleado()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasHoyEmpleado(ref dt, idUsuario);
            ReporteVentas.resumenVentas rpt = new ReporteVentas.resumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void ReporteResumenVentasFechas()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasFechas(ref dt, dtpFecIni.Value, dtpFecFin.Value);
            ReporteVentas.resumenVentas rpt = new ReporteVentas.resumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
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
        private void ReporteResumenVentasEmpleadoFechas()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasEmpleadoFechas(ref dt, idUsuario, dtpFecIni.Value, dtpFecFin.Value);
            ReporteVentas.resumenVentas rpt = new ReporteVentas.resumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }

        private void BtnHastaHoy_Click(object sender, EventArgs e)
        {
            if (PnResumenVentas.Visible == true)
            {
                ReporteResumenVentasHoy();
            }
            if (pnVentasEmpleado.Visible == true)
            {
                ReporteResumenVentasHoyEmpleado();
            }
            btnHastaHoy.ForeColor = Color.OrangeRed;
            checkFiltros.Checked = false;
            pnlFiltros.Visible = true;
            ReporteResumenVentasHoy();
        }

        private void CheckFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFiltros.Checked == true)
            {
                if (PnResumenVentas.Visible == true)
                {
                    pnlFechas.Enabled = true;
                    pnlFechas.Visible = true;
                    ReporteResumenVentasFechas();
                }
                if (pnVentasEmpleado.Visible == true)
                {
                    pnlFechas.Enabled = true;
                    pnlFechas.Visible = true;
                    ReporteResumenVentasEmpleadoFechas();
                }
                btnHastaHoy.ForeColor = Color.DimGray;
                pnlFechas.Visible = true;
            }
            else
            {
                if (PnResumenVentas.Visible == true)
                {
                    ReporteResumenVentasHoy();
                }
                if (pnVentasEmpleado.Visible == true)
                {
                    ReporteResumenVentasHoyEmpleado();
                }
                btnHastaHoy.ForeColor = Color.OrangeRed;
                pnlFechas.Visible = false;


            }
        }


        private void BtnVentasEmpleado_Click(object sender, EventArgs e)
        {
            PnResumenVentas.Visible = false;
            pnVentasEmpleado.Visible = true;
            pnlFiltros.Visible = true;
            pnlFechas.Enabled = false;
            btnResumenVentas.ForeColor = Color.FromArgb(0, 60, 103);
            pnlEmpleados.Visible = false;
            checkFiltros.Checked = false;
            checkFiltros.ForeColor = Color.FromArgb(0, 60, 103);
            pnlEmpleados.Visible = true;
            mostrarUsuarios();
            ReporteResumenVentasHoyEmpleado();
        }


        private void mostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarUsuarios(ref dt);
            txtEmpleado.DisplayMember = "Nombres_y_Apellidos";
            txtEmpleado.ValueMember = "idUsuario";
            txtEmpleado.DataSource = dt;
        }

        private void TxtEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            idUsuario = Convert.ToInt32(txtEmpleado.SelectedValue);
            if (checkFiltros.Checked == true)
            {
                ReporteResumenVentasEmpleadoFechas();
            }
            else
            {
                ReporteResumenVentasHoyEmpleado();
            }
        }


        private void validarFiltros()
        {
            if (checkFiltros.Checked == true)
            {
                if (PnResumenVentas.Visible == true)
                {
                    ReporteResumenVentasFechas();
                }
                if (pnVentasEmpleado.Visible == true)
                {
                    ReporteResumenVentasEmpleadoFechas();
                }
            }
        }

        private void DtpFecIni_ValueChanged(object sender, EventArgs e)
        {
            validarFiltros();
        }

        private void DtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            validarFiltros();
        }

        private void BtnCxC_Click(object sender, EventArgs e)
        {
            pnlVentas.Visible = false;
            pnlBienvenida.Visible = false;
            reportCobrar_Y_Pagar.Visible = true;
            pnlProductos.Visible = false;
            reportCobrar_Y_Pagar.Dock = DockStyle.Fill;

            //Botones
            btnVentas.BackColor = Color.FromArgb(214, 250, 250);
            btnVentas.ForeColor = Color.FromArgb(131, 135, 146);
            btnCxC.BackColor = Color.FromArgb(0, 85, 128);
            btnCxC.ForeColor = Color.White;
            btnCxP.BackColor = Color.FromArgb(214, 250, 250);
            btnCxP.ForeColor = Color.FromArgb(131, 135, 146);
            btnProductos.BackColor = Color.FromArgb(214, 250, 250);
            btnProductos.ForeColor = Color.FromArgb(131, 135, 146);
            ReporteCuentasPorCobrar();
        }


        private void ReporteCuentasPorCobrar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteCuentasPorCobrar(ref dt);
            ReportesCobros.ReporteCobros rpt = new ReportesCobros.ReporteCobros();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportCobrar_Y_Pagar.Report = rpt;
            reportCobrar_Y_Pagar.RefreshReport();


        }


        private void BtnCxP_Click(object sender, EventArgs e)
        {
            pnlVentas.Visible = false;
            pnlBienvenida.Visible = false;
            reportCobrar_Y_Pagar.Visible = true;
            pnlProductos.Visible = false;
            reportCobrar_Y_Pagar.Dock = DockStyle.Fill;

            //Botones
            btnVentas.BackColor = Color.FromArgb(214, 250, 250);
            btnVentas.ForeColor = Color.FromArgb(131, 135, 146);
            btnCxC.BackColor = Color.FromArgb(214, 250, 250);
            btnCxC.ForeColor = Color.FromArgb(131, 135, 146);
            btnCxP.BackColor = Color.FromArgb(0, 85, 128);
            btnCxP.ForeColor = Color.White;
            btnProductos.BackColor = Color.FromArgb(214, 250, 250);
            btnProductos.ForeColor = Color.FromArgb(131, 135, 146);
            ReporteCuentasPorPagar();
        }
        private void ReporteCuentasPorPagar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteCuentasPorPagar(ref dt);
            ReportesPagos.ReportesPagos rpt = new ReportesPagos.ReportesPagos();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportCobrar_Y_Pagar.Report = rpt;
            reportCobrar_Y_Pagar.RefreshReport();


        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            pnlVentas.Visible = false;
            pnlBienvenida.Visible = false;
            reportCobrar_Y_Pagar.Visible = true;
            pnlProductos.Visible = true;
            pnlProductos.Dock = DockStyle.Fill;

            //Botones
            btnVentas.BackColor = Color.FromArgb(214, 250, 250);
            btnVentas.ForeColor = Color.FromArgb(131, 135, 146);
            btnCxC.BackColor = Color.FromArgb(214, 250, 250);
            btnCxC.ForeColor = Color.FromArgb(131, 135, 146);
            btnCxP.BackColor = Color.FromArgb(214, 250, 250);
            btnCxP.ForeColor = Color.FromArgb(131, 135, 146);
            btnProductos.BackColor = Color.FromArgb(0, 85, 128);
            btnProductos.ForeColor = Color.White;

            //Paneles
            pnInventarios.Visible = false;
            pnProductosVencidos.Visible = false;
            pnStockBajo.Visible = false;
            reportViewer2.Visible = false;

           
        }

        private void BtnInventarios_Click(object sender, EventArgs e)
        {
            pnInventarios.Visible = true;
            pnProductosVencidos.Visible = false;
            pnStockBajo.Visible = false;
            reportViewer2.Visible = true;
            reportViewer2.Dock = DockStyle.Fill;
            imprimir_inventarios_todos();
        }
        private void imprimir_inventarios_todos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.imprimir_inventarios_todos(ref dt);
            REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.reportInventarios_Todos rpt = new REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.reportInventarios_Todos();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer2.Report = rpt;
            reportViewer2.RefreshReport();
        }

        private void BtnInventariosVencidos_Click(object sender, EventArgs e)
        {
            pnInventarios.Visible = false;
            pnProductosVencidos.Visible = true;
            pnStockBajo.Visible = false;
            reportViewer2.Visible = true;
            reportViewer2.Dock = DockStyle.Fill;
            mostrar_productos_vencidos();
        }
        private void mostrar_productos_vencidos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_productos_vencidos(ref dt);
            REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.ReportePVencidos rpt = new REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.ReportePVencidos();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer2.Report = rpt;
            reportViewer2.RefreshReport();
        }

        private void BtnStockBajo_Click(object sender, EventArgs e)
        {
            pnInventarios.Visible = false;
            pnProductosVencidos.Visible = false;
            pnStockBajo.Visible = true;
            reportViewer2.Visible = true;
            reportViewer2.Dock = DockStyle.Fill;
            MOSTRAR_Producto_Minimo();
        }
        private void MOSTRAR_Producto_Minimo()
        {
            DataTable dt = new DataTable();
            Obtener_datos.MOSTRAR_Inventarios_bajo_minimo(ref dt);
            REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.ReportePBajoMinimo rpt = new REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos.ReportePBajoMinimo();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer2.Report = rpt;
            reportViewer2.RefreshReport();
        }

    }
}
