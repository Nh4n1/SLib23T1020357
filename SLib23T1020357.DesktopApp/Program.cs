using System.Configuration;

namespace SLib23T1020357.DesktopApp
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

            string connectionString = ConfigurationManager.ConnectionStrings["SlibDB"]?.ConnectionString;
            ServiceManager.Initialize(connectionString);

            Application.Run(new FormMain());
        }
    }
}