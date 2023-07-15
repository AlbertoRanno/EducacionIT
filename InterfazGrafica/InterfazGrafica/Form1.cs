using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FormPrograma1 : Form
    {
        public FormPrograma1()
        {
            InitializeComponent();
            /* Creado como Windows Form App
             Click derecho sobre InitializeComponent - Go to implementation - para ver el codigo fuente
             En la solapa gráfica - toolbox - (view si no esta...)
             Al arrastrar un boton... se me carga de lineas de comandos el archivo fuente
             click derecho sobre el elemento, y accedo a modificar las properties
             por default viene nombrado generico... cambiar el nombre a algo coherente y respetando reglas de nombres de variable
             el nombre esta en las properties, dentro de design
            en el cuadrito de properties, arriba, el rayito, me va a desplegar un listado de eventos posibles
            para ese elemento.. con doble click, los crea/asocia, y me trae al codigo, para que le escriba
            dentro la funcionalidad que quiero que ejecute ese codigo:
            -Ej. doble click en Click, me crea:
             */
        }

        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            /*Lee lo de inDatos, y lo escribe en outDatos*/
            string txt;
            
            //le paso a la variable, lo que ingresa en inDatos
            txt = inDatos.Text; //inDatos es tipo "textBox", lo paso a string
            
            //le paso a outDatos, lo que tenia en txt, pasandolo al formato
            outDatos.Text = txt;
            
            /*Una vez terminado el programa, se puede correr SIN el IDE,
             desde su punto exe. Buscarlo dentro de la carpeta/bin/debug*/
        }
    }
}
