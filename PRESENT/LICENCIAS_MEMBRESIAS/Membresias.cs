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
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;
using PUNTO_DE_VENTA.DATE;
using System.Security.Cryptography;

namespace PUNTO_DE_VENTA.PRESENT.LICENCIAS_MEMBRESIAS
{
    public partial class Membresias : Form
    {
        public Membresias()
        {
            InitializeComponent();
        }
        string serialPc;
        string ruta;
        string dbcnString;
        string LicenciaDescifrada;
        private AES aes = new AES();
        string SerialPcLicencia;
        string FechaFinLicencia;
        string EstadoLicencia;
        string NombreSoftwareLicencia;
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void Membresias_Load(object sender, EventArgs e)
        {
            obtenerSerialPc();
        }

        private void obtenerSerialPc()

        {
            Bases.Obtener_serialPC(ref serialPc);
            txtSerial.Text = serialPc;
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSerial.Text);
        }

        private void BtnActivarManual_Click(object sender, EventArgs e)
        {
            dlg.Filter="Licecias VEGA|*.xml";
            dlg.Title = "Cargador de Licencias VEGA";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                ruta = Path.GetFullPath(dlg.FileName);
                DescifrarLicencia();
                string cadena = LicenciaDescifrada;
                string[] separadas = cadena.Split('|');
                SerialPcLicencia = separadas[1];
                FechaFinLicencia = separadas[2];
                EstadoLicencia = separadas[3];
                NombreSoftwareLicencia = separadas[4];
                if(NombreSoftwareLicencia=="VEGA")
                {
                    if(EstadoLicencia=="PENDIENTE")
                    {
                        if(SerialPcLicencia==serialPc)
                        {
                            activarLicenciaManual();
                        }
                    }
                }
            }

        }
        private void activarLicenciaManual()
        {
            Bases.Obtener_serialPC(ref serialPc);
            string fechaFin = (FechaFinLicencia);
            string estado = Bases.Encriptar("?ACTIVADO PRO?");
           
            string fechaActivacion = Bases.Encriptar(DateTime.Now.ToString());
            LMarcan parametros = new LMarcan();
            Editar_datos funcion = new Editar_datos();
            parametros.E = estado;
            parametros.FA = fechaActivacion;
            parametros.F = fechaFin;
            parametros.S = txtSerial.Text;
            MessageBox.Show(txtSerial.Text);

            if (funcion.editarMarcan(parametros) == true)
            {
                MessageBox.Show("Licencia activada, se cerrara el sistema para un nuevo Inicio");
                Application.Exit();
            }
        }
        private void DescifrarLicencia()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ruta);
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes.Item(0).Value;
                LicenciaDescifrada = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));
            }
            catch (CryptographicException ex)
            {


            }
    }   }
}
