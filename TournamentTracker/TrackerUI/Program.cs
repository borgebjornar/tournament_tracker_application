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
            TrackerLibrary.GlobalConfig.InitalizeConnections(TrackerLibrary.DatabaseType.Sql);
            Application.Run(new CreateTeamForm());
            
            //Application.Run(new TournamentDashboardForm());
        }
    }
}