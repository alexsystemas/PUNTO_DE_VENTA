using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.DATE;

namespace PUNTO_DE_VENTA.PRESENT.CORREOS_BASE
{
    public partial class ConfigurarCorreo : Form
    {
        public ConfigurarCorreo()
        {
            InitializeComponent();
        }

        private void BtnSincronizarGoogle_Click(object sender, EventArgs e)
        {
            bool estado;
            estado=Bases.enviarCorreo(textBox1.Text,textBox2.Text,"Sincronizacion con VEGA creada Correctamente","Sincronizacion con VEGA",textBox1.Text,"");
            if (estado==true)
            {
                editarCorreo();
                MessageBox.Show("Sincronizacion creda Correctamente", "Sincroinizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
            {
                MessageBox.Show("Sincronizacion Fallida, revisa el Video de Nuevo", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void editarCorreo()
        {
            Lcorreo parametros = new Lcorreo();
            Editar_datos funcion = new Editar_datos();
            parametros.Correo = Bases.Encriptar(textBox1.Text);
            parametros.Password = Bases.Encriptar(textBox2.Text);
            parametros.Estado_De_envio = Bases.Encriptar("Sincronizado");
            funcion.editar_correo_base(parametros);
        }
    }
}
