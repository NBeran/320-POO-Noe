using Drones.Helpers;

namespace Drones
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

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Joe"));
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 3, Config.AIRSPACE_HEIGHT / 3 + 10, "Mark"));
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2 + 135, Config.AIRSPACE_HEIGHT / 2 - 91, "Dan"));
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2 + 222, Config.AIRSPACE_HEIGHT - 222, "Bob"));
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT - 104, "Sam"));
            // Démarrage
            Application.Run(new AirSpace(fleet));
        }
    }
}