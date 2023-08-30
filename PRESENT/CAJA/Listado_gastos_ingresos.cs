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
        private void Listado_gastos_ingresos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            Obtener_datos.mostrar_gastos_por_turnos(idcaja, ref dt);
            datalistadoGastos.DataSource = dt;
        }
    }
}
