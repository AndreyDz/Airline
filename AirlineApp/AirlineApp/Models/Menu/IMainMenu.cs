using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models.Menu
{
   public interface IMainMenu
    {
        void MainMenu(ICollection<Flight> flights);
        void DisplayPassengers(ICollection<Flight> flights);
     //   void DisplayFlights(ICollection<Flight> flights);
        void DisplaySearchMenu(ICollection<Flight> flights);
        void DisplayDeleteMenu(ICollection<Flight> flights);
    }
}
