using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjLaboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            int nota1, nota2;

            nombre = TxtNombre.Text.Trim();
            nota1 = int.Parse(inNota1.Text);
            nota2 = int.Parse(inNota2.Text);

            double promedio = (nota1 + nota2) / 2.0;

            label4.Text = "El promedio de " + nombre + " es " + promedio.ToString();


        }
    }
}
