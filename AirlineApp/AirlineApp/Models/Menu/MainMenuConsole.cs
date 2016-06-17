using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models.Menu
{
    public class MainMenuConsole : IMainMenu
    {
        protected IInOut InOutModel { get; set; }
        protected IFlightManager FlightManager { get; set; }
        protected ICollection<Flight> Flights { get; set; }
      //  IEnumerable<Flight> Flights { get; set; }
        //public MainMenuConsole(IInOut inOutModel,IEnumerable<Flight> flights, IFlightManager flightManager)
        //{
        //    InOutModel = inOutModel;
        //    FlightManager = flightManager;

        //}
        public MainMenuConsole(IInOut inOutModel,IFlightManager flightManager/*, ICollection<Flight> flights*/ )
        {
            InOutModel = inOutModel;
            FlightManager = flightManager;
        }

        public void DisplayDeleteMenu(ICollection<Flight> flights)
        {
            bool isOk = false;
            string menu = "";
            do
            {
                InOutModel.OutputString(@"                  DELETE MENU");
                InOutModel.OutputString("*********************************************************");
                InOutModel.OutputString(@"            1 - Delte flight
            2 - Delte passenger 


                Any another button  - Menu ");
                menu = InOutModel.InputString();
                switch (menu)
                {
                    case "1":
                        FlightManager.DeleteFlight(flights,this);
                        isOk = true;
                        break;
                    case "2":
                     //   DeletePassenger(flights);
                        isOk = true;
                        break;
                    default:
                        InOutModel.ClearPanel();
                        MainMenu(flights);
                        isOk = false;
                        break;
                }
            }
            while (!isOk);
        }

        //public void DisplayFlights(ICollection<Flight> flights)
        //{
        //    InOutModel.UserOutputString(@"                                                                                ||            Price        ||");
        //    InOutModel.UserOutputString(@"--------------------------------------------------------------------------------||-------------------------||");
        //    InOutModel.UserOutputString(@"           ||  № ||   Date   || Time||     City     ||Terminal||Gate||  Status  ||      Econom || Buissnes ||");
        //    InOutModel.UserOutputString(@"           ||    ||          ||     ||              ||        ||    ||          ||             ||          ||");
        //    InOutModel.UserOutputString(@"-----------||----||----------||-----||--------------||--------||----||----------||-------------||----------||");
        //    flights.OrderBy(f=>f.Date);
        //    foreach (Flight flight in flights)
        //    {
        //        if (flight != null)
        //        {
        //            InOutModel.UserOutputString(flight.ToString());
        //        }
        //    }
            
            
            
        //    //for (int i = 0; i < flights.Length; i++)
        //    //{
        //    //    for (int j = planeList.Length - 1; j > i; j--)
        //    //    {
        //    //        if (planeList[j] != null && planeList[j - 1] != null)
        //    //        {
        //    //            if (planeList[j].Date < planeList[j - 1].Date)
        //    //            {
        //    //                Plane tmp = planeList[j];
        //    //                planeList[j] = planeList[j - 1];
        //    //                planeList[j - 1] = tmp;
        //    //            }
        //    //        }
        //    //    }
        //    //}
           
        //}

        public void DisplayPassengers(ICollection<Flight> flights)
        {
        }

        public void DisplaySearchMenu(ICollection<Flight> flights)
        {
        }

        public void MainMenu(ICollection<Flight> flights)
        {
            bool isOk = false;
            string menu = "";
            do
            {
                InOutModel.OutputString(@"                    MAIN MENU");
                InOutModel.OutputString("*********************************************************");
                InOutModel.OutputString(@"            1 - Display all flights
            2 - Display  passengers
            3 - Add new flight
            4 - Add new passenger
            5 - Search
            6 - Edit
            7 - Delete");
                menu = InOutModel.InputString();
                switch (menu)
                {
                    case "1":
                        InOutModel.ClearPanel();
                        FlightManager.DisplayFlights(flights);
                        MainMenu(flights);
                        isOk = true;
                        break;
                    case "2":
                        DisplayPassengers(flights);
                        isOk = true;
                        break;
                    case "3":
                        FlightManager.AddNewFlight(flights);
                        MainMenu(flights);
                        isOk = true;
                        break;
                    case "4":
                        InOutModel.ClearPanel();
                     //   DisplayAllPlanes(flights);
                     //   AddPassengerToPlane(flights);
                        isOk = true;
                        break;
                    case "5":
                      //  SearchMenu(flights);
                        isOk = true;
                        break;
                    case "6":
                     //   EditMenu(flights);
                        isOk = true;
                        break;
                    case "7":
                        InOutModel.ClearPanel();
                        DisplayDeleteMenu(flights);
                        isOk = true;
                        break;
                    default:
                        InOutModel.ClearPanel();
                        InOutModel.OutputString("You enetered wrong menu. Try again.".ToUpper());
                        InOutModel.OutputString("");
                        isOk = false;
                        break;
                }
            }
            while (!isOk);

        }
    }
}
