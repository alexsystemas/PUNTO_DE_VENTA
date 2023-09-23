using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Management;
using System.Data.SqlClient;
using System.Xml;
using System.Diagnostics;

namespace PUNTO_DE_VENTA.PRESENT.ASISTENTE_DE_ISTALACION_servidor
{
    public partial class Instalacion_del_servidorSQL : Form
    {
        public Instalacion_del_servidorSQL()
        {
            InitializeComponent();
        }

        private void Instalacion_del_servidorSQL_Load(object sender, EventArgs e)
        {
            centrarPaneles();
            remplazar();
            comprobar_si_ya_servidor_instalado_SQL_EXPRESS();
            conectar();

           

           

          

        }
        private void conectar()
        {

            if(btnInstalarServidor.Visible==true)
            {
                comprobar_si_ya_servidor_instalado_SQL_normal();
            }
           
        }
        private void remplazar()
        {
            txtEliminarBase.Text = txtEliminarBase.Text.Replace("BASEADA", txtBaseDeDatos.Text);
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("BASEADA", txtBaseDeDatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("VEGA389", txtUsuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("BASE_PUNTO_VENTA", txtBaseDeDatos.Text); 
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("softwarereal", lblcontraseña.Text);
            // Adjutando al texbox que contiene los procedimientos almacenados
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;


        }
        private void centrarPaneles()
        {
            string nombre_del_equipo_usuario;
            nombre_del_equipo_usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            pnlInstaladoServidor.Location = new Point((Width - panel2.Width) / 2, (Height - panel2.Height) / 2);
            Cursor = Cursors.WaitCursor;
            panel4.Visible = false;
            panel4.Dock = DockStyle.None;
        }
        private void comprobar_si_ya_servidor_instalado_SQL_EXPRESS()
        {
            txtservidor.Text = @".\" + lblnombredeservicio.Text;
            ejecutar_scrypt_ELIMINARBAse_comprobacion_de_inicio();
            ejecutar_scrypt_crearBase_comprobacion_de_inicio();
        }

        private void comprobar_si_ya_servidor_instalado_SQL_normal()
        {
            txtservidor.Text = ".";
            ejecutar_scrypt_ELIMINARBAse_comprobacion_de_inicio();
            ejecutar_scrypt_crearBase_comprobacion_de_inicio();
        }
        private CONEXION.AES aes = new CONEXION.AES();
        private  void ejecutar_scrypt_crearBase_comprobacion_de_inicio()
        {
            var cnn = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE " + txtBaseDeDatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(aes.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + txtBaseDeDatos.Text + ";Integrated Security=True", CONEXION.Desencryptacion.appPwdUnique, int.Parse("256")));
                ejecutar_scryt_crearProcedimientos_almacenados_y_tablas();
                pnlInstaladoServidor.Visible = true;
                pnlInstaladoServidor.Dock = DockStyle.Fill;
                lblInstalandoServidor.Text = @"Instancia Encontrada...
            No Cierre esta Ventana, se cerrara Automaticamente cuando este todo Listo";
                panel3.Visible = false;
                timer4.Start();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                panel3.Visible = true;
                btnInstalarServidor.Visible = true;
                pnlInstaladoServidor.Visible = false;
                pnlInstaladoServidor.Dock = DockStyle.None;
                lblbuscador_de_servidores.Text = "De click a Instalar Servidor, luego de click a SI cuando se le pida, luego presione ACEPTAR y espere por favor ";
            }


            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        string ruta;
        private void ejecutar_scryt_crearProcedimientos_almacenados_y_tablas()
        {
            ruta = Path.Combine(Directory.GetCurrentDirectory(), txtnombre_scrypt.Text + ".txt");
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;

            try
            {
                if (File.Exists(ruta) == false)
                {

                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                Process Pross = new Process();

                Pross.StartInfo.FileName = "sqlcmd";
                Pross.StartInfo.Arguments = " -S " + txtservidor.Text + " -i " + txtnombre_scrypt.Text + ".txt";
                Pross.Start();


                ////////Timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                //acaba = False
            }
        }

        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        private void ejecutar_scrypt_ELIMINARBAse_comprobacion_de_inicio()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if ((myConn.State == ConnectionState.Open))
                {
                    myConn.Close();
                }
            }
        }
        public static int milisegundo;
        public static int segundos;
        private void Timer4_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            milisegundo += 1;
            millseg.Text = Convert.ToString(milisegundo);
            if(milisegundo == 60)
            {
                segundos += 1;
                seg3.Text = Convert.ToString(segundos);
                milisegundo = 0;
            }
            if (segundos == 15)
            {
                timer4.Stop();
                try
                {
                    File.Delete(ruta);
                }
                catch (Exception)
                {

                    throw;
                }
                Dispose();
                Application.Restart();
            }
        }

      

        private void  executa()
        {
            try
            {
                Process pross = new Process();
                pross.StartInfo.FileName = "SQLEXPR_x86_ESN.exe";
                pross.StartInfo.Arguments = "/ConfigurationFile=ConfigurationFile.ini /ACTION=Install /IACCEPTSQLSERVERLICENSETERMS /SECURITYMODE=SQL /SAPWD=" + lblcontraseña.Text + " /SQLSYSADMINACCOUNTS=" + nombre_del_equipo_usuario;

                pross.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                pross.Start();
                pnlInstaladoServidor.Visible = true;
                pnlInstaladoServidor.Dock = DockStyle.Fill;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TimerCRARINI_Tick(object sender, EventArgs e)
        {
            string rutaPREPARAR;
            StreamWriter sw;
            rutaPREPARAR = Path.Combine(Directory.GetCurrentDirectory(), "ConfigurationFile.ini");
            rutaPREPARAR = rutaPREPARAR.Replace("ConfigurationFile.ini", @"SQLEXPR_x86_ESN\ConfigurationFile.ini");


            if (File.Exists(rutaPREPARAR) == true)
            {
                timerCRARINI.Stop();
            }

            try
            {
                sw = File.CreateText(rutaPREPARAR);
                sw.WriteLine(txtArgumentosini.Text);
                sw.Flush();
                sw.Close();
                timerCRARINI.Stop();
            }
            catch (Exception ex)
            {

            }
        }
        public static int milisegundo1;
        public static int segundos1;
        public static int minutos1;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            milisegundo1 += 1;
            milise.Text = Convert.ToString(milisegundo1);
            if (milisegundo1 == 60)
            {
                segundos1 += 1;
                seg.Text = Convert.ToString(segundos1);

                milisegundo1 = 0;

            }

            if (segundos1 == 60)
            {
                minutos1 += 1;

                min.Text = Convert.ToString(minutos1);
                segundos1 = 0;
            }

            if (minutos1 == 6)
            {
                timer2.Enabled = false;

                ejecutar_scryt_ELIMINARBase();
                ejecutar_scryt_crearBase();

                timer3.Start();
            }
        }

        private void ejecutar_scryt_ELIMINARBase()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if ((myConn.State == ConnectionState.Open))
                {
                    myConn.Close();
                }
            }
        }

        private void ejecutar_scryt_crearBase()
        {
            var cnn = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE " + txtBaseDeDatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(aes.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + txtBaseDeDatos.Text + ";Integrated Security=True", CONEXION.Desencryptacion.appPwdUnique, int.Parse("256")));
                ejecutar_scryt_crearProcedimientos_almacenados_y_tablas();

                timer4.Start();
            }
            catch (Exception ex)
            {

            }


            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            milisegundo1 += 1;
            milise.Text = Convert.ToString(milisegundo1);
            if (milisegundo1 == 60)
            {
                segundos1 += 1;
                seg.Text = Convert.ToString(segundos1);

                milisegundo1 = 0;

            }

            if (segundos1 == 60)
            {
                minutos1 += 1;

                min.Text = Convert.ToString(minutos1);
                segundos1 = 0;
            }

            if (minutos1 == 1)
            {

                ejecutar_scryt_ELIMINARBase();
                ejecutar_scryt_crearBase();

               
            }
        }

        private void BtnInstalarServidor_Click(object sender, EventArgs e)
        {
            try
            {
                txtArgumentosini.Text = txtArgumentosini.Text.Replace("PRUEBAFINAL22", lblnombredeservicio.Text);
                timerCRARINI.Start();
                executa();
                timer2.Start();
                pnlInstaladoServidor.Visible = true;
                pnlInstaladoServidor.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
