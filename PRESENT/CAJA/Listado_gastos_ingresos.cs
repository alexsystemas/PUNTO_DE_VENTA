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

namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    public partial class Listado_gastos_ingresos : Form
    {
        public Listado_gastos_ingresos()
        {
            InitializeComponent();
        }
        int idcaja;
        DateTime fechaInicial;
        DateTime fechaFinal;
        private void Listado_gastos_ingresos_Load(object sender, EventArgs e)
        {
            fechaFinal = DateTime.Now;
            mostrar_cierre_de_caja_pendientes();
            listar_gastos();
          
        }
        private void listar_gastos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_gastos_por_turnos(idcaja, fechaInicial, fechaFinal, ref dt);
            datalistadoGastos.DataSource = dt;
        }
        private void mostrar_cierre_de_caja_pendientes()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_cierre_de_caja_pendiente(ref dt);
            foreach(DataRow dr in dt.Rows)
            {
                idcaja =Convert.ToInt32( dr["Id_caja"]);
                fechaInicial =Convert.ToDateTime( dr["fechainicio"]);
            }
        }
    }
}
