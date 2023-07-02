namespace WinFormsClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            /*Sigue siendo una clase
             Tengo un metodo constructor: public Form1()
            y este constructor llama a un metodo InitializeComponent 
            Posicionado sobre él, y con f12, o click derecho y go to definition
            y accedo asi al codigo que se genera detras de la interfaz*/
            InitializeComponent();
            /*Poniendo botones... programacion orientada a eventos (clicks)
            A cada boton le doy un nombre*/


        }

        private void BtnDiagnostico_Click(object sender, EventArgs e)
        {
            FrmDiagnostico frmDiagnostico = new FrmDiagnostico();
            frmDiagnostico.Show();
            this.Close();
        }
    }
}