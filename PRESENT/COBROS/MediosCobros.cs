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
namespace PUNTO_DE_VENTA.PRESENT.COBROS
{
    public partial class MediosCobros : Form
    {
        public MediosCobros()
        {
            InitializeComponent();
        }
        double saldo;
        int idcliente;
        int idcaja;
        int idusuario;
        double efectivo;
        double tarjeta;
        double vuelto;
        double restante;
        double efectivoCalculado;
        double montoabonado;
        private void MediosCobros_Load(object sender, EventArgs e)
        {
            saldo = CobrosForm.saldo;
            lblTotal.Text = saldo.ToString();
            idcliente = CobrosForm.idcliente;
            Obtener_datos.obtener_id_caja_PorSerial(ref idcaja);
            Obtener_datos.mostrar_inio_de_secion(ref idusuario);
        }
        private void calcularRestante()
        {
            try
            {
                efectivo = 0;
                tarjeta = 0;
                if (string.IsNullOrEmpty(txtEfectivo.Text))
                {
                    efectivo = 0;

                }
                else
                {
                    efectivo = Convert.ToDouble(txtEfectivo.Text);
                }
                if (string.IsNullOrEmpty(txtTarjeta.Text))
                {
                    tarjeta = 0;

                }
                else
                {
                    tarjeta = Convert.ToDouble(txtTarjeta.Text);
                }
                // calculo de vuelto
                if (efectivo > saldo)
                {
                    vuelto = efectivo - saldo;
                    efectivoCalculado = (efectivo - vuelto);
                    txtVuelto.Text = vuelto.ToString();
                }
                else
                {
                    vuelto = 0;
                    efectivoCalculado = efectivo;
                    txtVuelto.Text = vuelto.ToString();  
                }

                //calculo restante 
                restante = saldo - efectivoCalculado - tarjeta;
                txtRestante.Text = restante.ToString();
                if(restante<0)
                {
                    txtRestante.Visible = false;
                    label6.Visible = false;
                }
                else
                {
                    txtRestante.Visible = true;
                    label6.Visible = true;
                }
                if(tarjeta==saldo)
                {
                    efectivo = 0;
                    txtEfectivo.Text = efectivo.ToString();
                }
                if(tarjeta>saldo)
                {
                    MessageBox.Show("El Pago con tarjeta no puede ser mayor que el saldo");
                    tarjeta = 0;
                    txtTarjeta.Text = tarjeta.ToString();
                }
                 
            }

            catch (Exception)
            {

                throw;
            }

        }

        private void TxtEfectivo_TextChanged(object sender, EventArgs e)
        {
            calcularRestante();
        }

        private void TxtTarjeta_TextChanged(object sender, EventArgs e)
        {
            calcularRestante();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
             montoabonado = efectivoCalculado + tarjeta;
            if(montoabonado>0)
            {
                insertarControlCobros();
                disminuirSaldocliente();
            }
          else
            {
                MessageBox.Show("Especifique un monto a abonar");
            }
            
        }
        private void insertarControlCobros()
        {
            LcontrolCobros parametros = new LcontrolCobros();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Monto = efectivoCalculado + tarjeta;
            parametros.Fecha = DateTime.Now;
            parametros.Detalle = "cobro de cliente";
            parametros.idCliente = idcliente;
            parametros.idUsusario = idusuario;
            parametros.idCaja = idcaja;
            parametros.Comprobante = "-";
            parametros.Efectivo = efectivoCalculado;
            parametros.Tarjeta = tarjeta;
            if (funcion.Insertar_ControlCobros(parametros) == true)
            {
                Dispose();
            }
        }

        private void disminuirSaldocliente()
        {
            Lclientes parametros = new Lclientes();
            Editar_datos funcion = new Editar_datos();
            parametros.idclientev = idcliente;
            funcion.disminuirSaldocliente(parametros, montoabonado);

        }
     }
}
