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
using PUNTO_DE_VENTA.LOGIC;

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
            listar_ingresos();
          
        }
        private void listar_gastos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_gastos_por_turnos(idcaja, fechaInicial, fechaFinal, ref dt);
            datalistadoGastos.DataSource = dt;
            datalistadoGastos.Columns[1].Visible = false;
            sumar_gastos();
            Bases.Multilinea(ref datalistadoGastos);
        }
        private void sumar_gastos()
        {
            double total=0;
            foreach(DataGridViewRow fila in datalistadoGastos.Rows)
            {
                total +=Convert.ToDouble( (fila.Cells["Importe"].Value));
            }
            lblGastos.Text =Convert.ToString( total);
        }
        private void sumar_ingresos()
        {
            double total = 0;
            foreach (DataGridViewRow fila in datalistadoIngresos.Rows)
            {
                total += Convert.ToDouble((fila.Cells["Importe"].Value));
            }
            lblIngresos.Text = Convert.ToString(total);
        }
        private void listar_ingresos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_ingresos_por_turnos(idcaja, fechaInicial, fechaFinal, ref dt);
            datalistadoIngresos.DataSource = dt;
            Bases.Multilinea(ref datalistadoIngresos);
            datalistadoIngresos.Columns[1].Visible = false;
            sumar_ingresos();

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

        private void DatalistadoGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==datalistadoGastos.Columns["EliminarG"].Index)
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este gasto?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result==DialogResult.OK)
                {
                    int idgasto = Convert.ToInt32(datalistadoGastos.SelectedCells[1].Value);
                    Eliminar_datos.eliminar_gasto(idgasto);
                    listar_gastos();
                }
            }
        }

        private void DatalistadoIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoIngresos.Columns["EliminarI"].Index)
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Ingreso?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idIngreso = Convert.ToInt32(datalistadoIngresos.SelectedCells[1].Value);
                    Eliminar_datos.eliminar_ingresos(idIngreso);
                    listar_ingresos();
                }
            }
        }
    }
}
