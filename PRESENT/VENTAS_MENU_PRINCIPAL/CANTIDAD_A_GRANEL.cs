using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;


namespace PUNTO_DE_VENTA.PRESENT.VENTAS_MENU_PRINCIPAL
{
    public partial class CANTIDAD_A_GRANEL : Form
    {
        public CANTIDAD_A_GRANEL()
        {
            InitializeComponent();
        }
        private string Bufeerrespuesta;
        private delegate void DelegadoAcceso(string accion);

       
        string puertoBalanza;
        string estadoPuerto;

        private void AccesoForm(string accion)
        {
            Bufeerrespuesta = accion;
            txtCantidad.Text = Bufeerrespuesta;
        }
        private void accesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_delegadoacceso;
            Var_delegadoacceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_delegadoacceso, arg);
        }

        private void puertos_DataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            accesoInterrupcion(puertos.ReadExisting());
        }



        public  double preciounitario;
        private void CANTIDAD_A_GRANEL_Load(object sender, EventArgs e)
        {
            txtprecio_unitario.Text = Convert.ToString(preciounitario);
            mostrarPuertos();


        }
        private void abrirPuertosBalanza()
        {
            puertos.Close();
            try
            {
                puertos.BaudRate = 9600;
                puertos.DataBits = 8;
                puertos.Parity = Parity.None;
                puertos.StopBits = (StopBits)1;
                puertos.PortName = puertoBalanza;
                MessageBox.Show(puertoBalanza);
                puertos.Open();
                if (puertos.IsOpen)
                {
                    estadoPuerto = "Conectado";
                }
                else
                {
                    estadoPuerto = "Fallo la conexion";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrarPuertos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarPuertos(ref dt);
            foreach (DataRow rdr in dt.Rows)
            {
                puertoBalanza = rdr["PuertoBalanza"].ToString();
                estadoPuerto = rdr["EstadoBalanza"].ToString();
            }
            MessageBox.Show(estadoPuerto);
            if (estadoPuerto == "CONFIRMADO")
            {
                abrirPuertosBalanza();
            }
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void calcularTotal()
        {
            try
            {
                double total;
                double cantidad;
                cantidad = Convert.ToDouble(txtCantidad.Text);
                total = preciounitario * cantidad;
                txtTotal.Text = Convert.ToString(total);
            }
            catch (Exception)
            {

              
            }
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            VENTAS_MENU_PRINCIPALOK.txtpantalla=Convert.ToDouble( txtCantidad.Text);
            Dispose();
        }

       

    }
   
}
