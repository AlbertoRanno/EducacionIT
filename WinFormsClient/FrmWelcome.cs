using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome(string TextWelcome)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            /*Propiedades. Evemtos, doble click sobre el boton que quiero, y
             me trae aca, con este evento ya generado. Le escribo yo MessageBox
            que es similar al console. writeline*/
            //MessageBox.Show("Presionaste click");
            FrmMain frmMain = new FrmMain();
            /* cree una instancia/objeto del formulario main
             a traves de frmMain. accedo a sus metodos*/
            frmMain.Show();
        }
    }
}
