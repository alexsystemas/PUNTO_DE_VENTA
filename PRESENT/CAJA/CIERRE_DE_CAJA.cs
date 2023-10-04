using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using PUNTO_DE_VENTA.DATE;

namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    public partial class lblVentasTotal : Form
    {
        public lblVentasTotal()
        {
            InitializeComponent();
        }
        public static double dineroEnCaja;
        int idcaja;
        DateTime fechaInicial;
        DateTime fechaFinal=DateTime.Now;
        double saldoInicial;
        double ventasEfectivo;
        double ingresosEfectivo;
        double gastosEfectivo;
        double ventasCredito;
        double ventasTarjeta;
        double efectivoEnCaja;
        double ventastotales;
        double creditosPorPagar;
        double creditosPorCobrar;

        private void CIERRE_DE_CAJA_Load(object sender, EventArgs e)
        {
            mostrar_cierre_de_caja_pendientes();
            lblDesdeHasta.Text = "Corte de caja desde: " + fechaInicial + " Hasta: " + DateTime.Now;
            obtener_saldo_inicial();
            obtener_ventas_En_Efectivo();
            obtener_gastos_por_turno();
            obtener_ingresos_por_turno();
            obtener_creditosPorPagar();
            sumar_creaditoPorCobrar();
            
            mostrar_ventas_Tarjeta_por_turno();
            mostrar_ventas_creadito_por_turno();
            calcular();
        }

        private void calcular()
        {
            efectivoEnCaja = saldoInicial + ventasEfectivo + ingresosEfectivo - gastosEfectivo;
            ventastotales = ventasEfectivo + ventasCredito + ventasTarjeta;
            //---Mostrar en labels
            lblDineroEncaja.Text = efectivoEnCaja.ToString();
            lblVentasTotales.Text = ventastotales.ToString();
            lbltotalventas.Text = ventastotales.ToString();
            lbldineroTotalCaja.Text = efectivoEnCaja.ToString();
        }
        private void obtener_ingresos_por_turno()
        {
            Obtener_datos.sumar_ingresos_por_turno(idcaja, fechaInicial, fechaFinal, ref ingresosEfectivo);
            lblIngresos.Text = ingresosEfectivo.ToString();
        }
        private void obtener_gastos_por_turno()
        {
            Obtener_datos.sumar_gastos_por_turno(idcaja, fechaInicial, fechaFinal, ref gastosEfectivo);
            lblGastos.Text = gastosEfectivo.ToString();
        }

        private void obtener_ventas_En_Efectivo()
        {
            Obtener_datos.mostrar_ventas_en_efectivo_por_turno(idcaja, fechaInicial, fechaFinal, ref ventasEfectivo);
            lblVentasEfectivo.Text = ventasEfectivo.ToString();
            lblVentasEfectivoGeneral.Text = ventasEfectivo.ToString();
        }

        private void obtener_saldo_inicial()
        {
            lblFondoDeCaja.Text = Convert.ToString(saldoInicial);
        }

        private void obtener_creditosPorPagar()
        {
            Obtener_datos.sumar_creaditoPorPagar(idcaja, fechaInicial, fechaFinal, ref creditosPorPagar);
            lblPorPagar.Text = creditosPorPagar.ToString();
        }

        private void sumar_creaditoPorCobrar()
        {
            Obtener_datos.sumar_creaditoPorCobrar(idcaja, fechaInicial, fechaFinal, ref creditosPorCobrar);
            lblPorCobrar.Text = creditosPorCobrar.ToString();
        }
        private void mostrar_cierre_de_caja_pendientes()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_cierre_de_caja_pendiente(ref dt);
            foreach (DataRow dr in dt.Rows)
            {
                idcaja = Convert.ToInt32(dr["Id_caja"]);
                fechaInicial = Convert.ToDateTime(dr["fechainicio"]);
                saldoInicial = Convert.ToDouble(dr["saldoInicial"]);

            }
        }

        private void mostrar_ventas_Tarjeta_por_turno()
        {
            Obtener_datos.mostrar_ventas_Tarjeta_por_turno(idcaja, fechaInicial, fechaFinal, ref ventasTarjeta);
            lblVentas_Tarjeta.Text = ventasTarjeta.ToString();
        }

        private void mostrar_ventas_creadito_por_turno()
        {
            Obtener_datos.mostrar_ventas_creadito_por_turno(idcaja, fechaInicial, fechaFinal, ref ventasCredito);
            lblVentas_Credito.Text = ventasCredito.ToString();
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            CierreTurno frm = new CierreTurno();
            dineroEnCaja =Convert.ToDouble( lblDineroEncaja.Text);
            frm.ShowDialog();
        }
    }
}
