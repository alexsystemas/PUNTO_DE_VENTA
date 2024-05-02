using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.PRESENT.COMPRAS
{
    public partial class relizarCompra : UserControl
    {
        public relizarCompra()
        {
            InitializeComponent();
        }
        string estadocompra;
        int idproducto;
        Panel paanel_mostrador_de_productos = new Panel();
        string tipo_de_busqueda;
        int idcompra=0;
        int idproveedor;
        string seveendepor;
        double txtpantalla;
        int iddetallecompra;

        private void RelizarCompra_Load(object sender, EventArgs e)
        {
            estadocompra = "COMPRA NUEVA";

        }
    }
}
