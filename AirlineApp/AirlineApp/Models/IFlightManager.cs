using AirlineApp.Enums;
using AirlineApp.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models
{
    public interface IFlightManager
    {
        ICollection<Flight> AddNewFlight(ICollection<Flight> flights);

        ICollection<Flight> DeleteFlight(ICollection<Flight> flights, IMainMenu mainMenu);
        string SetCity();

        int SetFlightNumber();

        int SetGate();

        Status SetStatus();

        char SetTerminal();

        DateTime SetDate();

        RaceType EditFlightRace();

        decimal SetEconomPrice();

        decimal SetBuissnesPrice();

        void DisplayFlights(ICollection<Flight> flights);
    }
}
