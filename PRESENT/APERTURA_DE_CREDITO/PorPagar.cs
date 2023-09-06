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

namespace PUNTO_DE_VENTA.PRESENT.APERTURA_DE_CREDITO
{
    public partial class PorPagar : Form
    {
        public PorPagar()
        {
            InitializeComponent();
        }
        int idProveedor;
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }
        private void insertarCreditos()
        {
            LcreditosPorPagar parametros = new LcreditosPorPagar();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Descripcion = txtConcepto.Text;
            parametros.Fecha_registro = txtFechaRegistro.Value;
            parametros.Fecha_vencimiento = txtFechaVencimiento.Value;
            parametros.Total =Convert.ToDouble( txtSaldo.Text);
            parametros.Saldo= Convert.ToDouble(txtSaldo.Text);
            parametros.Id_proveedor = idProveedor;
            if(funcion.insertar_CreditoPorPagar(parametros)==true)
            {

            }

        }
    }
}
