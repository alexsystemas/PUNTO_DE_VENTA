using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;

namespace PUNTO_DE_VENTA.PRESENT.BALANZA_ELECTRONICA
{
    public partial class BalanzaForm : Form
    {
        public BalanzaForm()
        {
            InitializeComponent();
        }
        private string Bufeerrespuesta;
        private delegate void DelegadoAcceso(string accion);
        private void AccesoForm(string accion)
        {
            Bufeerrespuesta = accion;
            txtResultado.Text = Bufeerrespuesta;
        }
        private void accesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_delegadoacceso;
            Var_delegadoacceso = new DelegadoAcceso(AccesoForm);
            object[] arg =  { accion };
            base.Invoke(Var_delegadoacceso, arg);
        }
        private void puertos_DataReceived(Object sender, SerialDataReceivedEventArgs e )
        {
            accesoInterrupcion(puertos.ReadExisting());
        }
        private void BalanzaForm_Load(object sender, EventArgs e)
        {
            listarPuertos();
        }
        private void listarPuertos()
        {
            try
            {
                ListaPuertos.Items.Clear();
                string[] PuertosDisponibles = SerialPort.GetPortNames();
                foreach (string puerto in PuertosDisponibles)
                {
                    ListaPuertos.Items.Add(puerto);
                }
                if(ListaPuertos.Items.Count>0)
                {
                    ListaPuertos.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron puertos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se encontraron puertos");
            }
        }

        private void BtnProbar_Click(object sender, EventArgs e)
        {
            puertos.Close();
            try
            {
                puertos.BaudRate = 9600;
                puertos.DataBits = 8;
                puertos.Parity = Parity.None;
                puertos.StopBits = (StopBits)1;
                puertos.PortName = ListaPuertos.Text;
                puertos.Open();
                if(puertos.IsOpen)
                {
                    lblEstado.Text = "Conectado";
                }
                else
                {
                    MessageBox.Show("Fallo la conexion"); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Btneviarr_Click(object sender, EventArgs e)
        {
            if (puertos.IsOpen)
            {
                puertos.WriteLine(txtResultado.Text);
            }
            else
            {
                MessageBox.Show("Fallo la conexion");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtResultado.Text))

            {
                editarBascula();
            }
           else
            {
                MessageBox.Show("El resultado tiene que ser diferente  de vacio para confirar la balanza ");
            }


        }
        private void editarBascula()
        {
            Lcaja parametros = new Lcaja();
            Editar_datos funcion = new Editar_datos();
            parametros.EstadoBalanza = "CONFIRMADO";
            parametros.PuertoBalanza = ListaPuertos.Text;
            if (funcion.EditarBascula(parametros) == true)
            {
                MessageBox.Show("Balanza configurada y guardada correctameente");
            }
        }
    }
}
