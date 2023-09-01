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
    public partial class CIERRE_DE_CAJA : Form
    {
        public CIERRE_DE_CAJA()
        {
            InitializeComponent();
        }
        int idcaja;
        DateTime fechaInicial;
        DateTime fechaFinal=DateTime.Now;
        double saldoInicial;
        double ventasEfectivo;
        double ingresosEfectivo;
        double gastosEfectivo;
        private void CIERRE_DE_CAJA_Load(object sender, EventArgs e)
        {
            mostrar_cierre_de_caja_pendientes();
            lblDesdeHasta.Text = "Corte de caja desde: " + fechaInicial + " Hasta: " + DateTime.Now;
            obtener_saldo_inicial();
            obtener_ventas_En_Efectivo();
            obtener_gastos_por_turno();
            obtener_ingresos_por_turno();
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
    }
}
