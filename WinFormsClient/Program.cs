namespace WinFormsClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmWelcome( TextWelcome())); //Le paso como parametro al metodo que cree debajo
        }

        static string TextWelcome()
        {
            ¨return "Bienvenido a IMCPlatform tu plataforma segura para saver como esta tu salud en general.";
        }
    }
}