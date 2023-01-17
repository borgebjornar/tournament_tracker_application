namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections.
            TrackerLibrary.GlobalConfig.InitalizeConnections(TrackerLibrary.DatabaseType.TextFile);
            Application.Run(new CreateTournamentForm());
            
            //Application.Run(new TournamentDashboardForm());
        }
    }
}