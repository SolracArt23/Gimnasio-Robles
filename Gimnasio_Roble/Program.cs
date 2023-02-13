namespace Gimnasio_Roble
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //inicializar la aplicacion
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
        }
    }
}