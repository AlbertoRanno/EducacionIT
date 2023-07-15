using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtInformacion.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, clave;

            /*Lectura de datos*/
            usuario = txtUsuario.Text;
            clave = txtContrasena.Text;

            if (usuario == "pepito")
            {
                if (clave == "educacionIT")
                {
                    txtInformacion.Text = "Bienvenido Pepito";
                }
                else
                {
                    txtInformacion.Text = "Usuario no coincide con clave";
                }
            }
            else
            {
                txtInformacion.Text = "Usuario no existe";
            }
        }
    }
}
