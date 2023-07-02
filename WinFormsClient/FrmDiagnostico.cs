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
    public partial class FrmDiagnostico : Form // Los : implican herencia, por eso puedo usar sus propiedades (del form) y puedo usar this.Close
    {
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //vuelvo hacia atras - hay varias formas
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close(); //se ubica en el contexto actual, igual que en JS
            //la saca de memoria!! buena practica importante!!

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /*TAB INDEX (ORDEN EN QUE SALTA EL TAB)
         SIRVE PARA QUE HAGA EL MENOS CLICK POSIBLE
        ESTA EN LAS PROPIEDADES COMO "TabIndex 0" y le ordeno los numeros en el orden que quiera*/
    }
}
