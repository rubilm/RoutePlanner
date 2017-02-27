using System;
using System.Reflection;
using Fhnw.Ecnf.RoutePlanner.RoutePlannerLib;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerConsole
{
    class RoutePlannerConsoleApp
    {
       static void Main(string[] args)
        {
            string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine($" Welcome to RoutePlanner ({ver})");
            Console.ReadKey();

            var wayPoint = new WayPoint("Windisch", 47.479319847061966, 8.212966918945312);
            Console.WriteLine($"{wayPoint.Name}: {wayPoint.Latitude}/{wayPoint.Longitude}");
            Console.ReadKey();
        }
    }
}
