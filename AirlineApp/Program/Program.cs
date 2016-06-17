using AirlineApp.Enums;
using AirlineApp.Models;
using AirlineApp.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Flight> flights = new List<Flight>() { new Flight() { FligthNumber=125, RaceType = RaceType.Arrival, City="LONDON",Status=Status.In_Flight,
                                                                        Date=DateTime.Parse("29.08.2016 15:00"), Gate=15, Terminal='A', EconomPrice=125, BuissnesPrice=333} };

            IInOut InOutModel = new InOutConsole();
            IFlightManager flightManager = new FlightManagerConsole(InOutModel);
            IMainMenu mainMenu = new MainMenuConsole(InOutModel, flightManager/*, flights*/);
            mainMenu.MainMenu(flights);
            Console.ReadLine();
        }
    }
}
