using TaskPlanner.Persistance;

namespace TaskPlanner
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

            DataContext ctx = new DataContext();

            Application.Run(new TaskPlanner(ctx));
        }
    }
}