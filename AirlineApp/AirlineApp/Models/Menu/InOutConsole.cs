using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models.Menu
{
    public class InOutConsole : IInOut

    {
        //public void DisplayFlights(IEnumerable<Flight> flights)
        //{

        //}
        //public void DisplayPassengers(IEnumerable<Flight> flights)
        //{

        //}
        //public void DisplaySearchMenu()
        //{

        //}
        //public void MainMenu(IEnumerable<Flight> flights)
        //{
        //    bool isOk = false;
        //    string menu = "";
        //    do
        //    {
        //        Console.WriteLine(@"                    MAIN MENU");
        //        Console.WriteLine("*********************************************************");
        //        Console.WriteLine(@"            1 - Display all flights
        //    2 - Display  passengers
        //    3 - Add new flight
        //    4 - Add new passenger
        //    5 - Search
        //    6 - Edit
        //    7 - Delete");
        //        menu = Console.ReadLine();
        //        switch (menu)
        //        {
        //            case "1":
        //                Console.Clear();
        //                DisplayFlights(flights);
        //                MainMenu(flights);
        //                isOk = true;
        //                break;
        //            case "2":
        //                DisplayPassengers(flights);
        //                isOk = true;
        //                break;
        //            case "3":
        //              //  AddPlane(flights);
        //                MainMenu(flights);
        //                isOk = true;
        //                break;
        //            case "4":
        //                Console.Clear();
        //              //  DisplayAllPlanes(flights);
        //             //   AddPassengerToPlane(flights);
        //                isOk = true;
        //                break;
        //            case "5":
        //            //    SearchMenu(flights);
        //                isOk = true;
        //                break;
        //            case "6":
        //          //      EditMenu(flights);
        //                isOk = true;
        //                break;
        //            case "7":
        //                Console.Clear();
        //              //  deleteManager.DeleteMenu(flights);
        //               // DisplayAllPlanes(flights);
        //                isOk = true;
        //                break;
        //            default:
        //                Console.Clear();
        //                Console.WriteLine("You enetered wrong menu. Try again.".ToUpper());
        //                Console.WriteLine("");
        //                isOk = false;
        //                break;
        //        }
        //    }
        //    while (!isOk);
        //}
        //public void DisplaySearchMenu(IEnumerable<Flight> flights) { }
        //public void DisplayDeleteMenu(IEnumerable<Flight> flights) { }


        public string InputString() => Console.ReadLine();
        public void OutputString(string text) => Console.WriteLine(text);
        public void ClearPanel() => Console.Clear();
    }
}

