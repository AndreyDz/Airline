using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineApp.Enums;
using AirlineApp.Models.Menu;

namespace AirlineApp.Models
{
    public class FlightManagerConsole : IFlightManager
    {
        IInOut InOutModel { get; set; }

        public FlightManagerConsole(IInOut inOutModel )
        {
            InOutModel = inOutModel;
        }

        public ICollection<Flight> AddNewFlight(ICollection<Flight> flights)
        {
            bool isOk = false;
            Flight flight = new Flight();
            flight.RaceType = EditFlightRace();
            flight.FligthNumber = SetFlightNumber();
            flight.City = SetCity();
            flight.Date = SetDate();
            flight.Status = SetStatus();
            flight.Terminal = SetTerminal();
            flight.Gate = SetGate();
            flight.EconomPrice = SetEconomPrice();
            do
            {
                flight.BuissnesPrice = SetBuissnesPrice();
                if (flight.BuissnesPrice > flight.EconomPrice)
                    isOk = true;
                else
                    InOutModel.OutputString("Buissnes Tickets must be more expencive");
            }
            while (!isOk);
            flights.Add(flight);
            //List<Flight> FlightList =
            return flights;
        }

        public ICollection<Flight> DeleteFlight(ICollection<Flight> flights, IMainMenu mainMenu)
        {
            Flight flightTmp = new Flight();
            int index = -1;
            bool isOk = false;
            bool isConsist = false;
            string menu = "";
            int number = 0;
        InOutModel.ClearPanel();
            if (!isOk)
            {
                do
                {
                    DisplayFlights(flights);
                    InOutModel.OutputString("Enter Number of flight you to delete");
                    if (int.TryParse(InOutModel.InputString(), out number))
                        isOk = true;
                    else
                    {
                        InOutModel.ClearPanel();
                        InOutModel.OutputString("");
                        InOutModel.OutputString("You enter wrong data ");
                        InOutModel.OutputString("");

                        isOk = false;
                    }

                }
                while (!isOk);
            }
            flightTmp = flights.FirstOrDefault(x => x.FligthNumber == number);
            
            if (flightTmp == null)
            {
                InOutModel.OutputString($"NOTHING FOUND! It's no any flight with this number {number}. Press any key to continue");
                InOutModel.InputString();
                //EditMenu(planeList);
            }
            isOk = false;
            do
            {
                InOutModel.OutputString("Are you sure  (Y/N) ? ");
                menu = InOutModel.InputString().ToUpper();
                switch (menu)
                {
                    case "Y":
                        InOutModel.ClearPanel();
                        flights.Remove(flightTmp);
                        DisplayFlights(flights);
                        mainMenu.MainMenu(flights);
                        isOk = true;
                        break;
                    case "N":
                       mainMenu.MainMenu(flights);
                        break;
                    default:
                        InOutModel.OutputString("Uncorrect menu");
                        isOk = false;
                        break;
                }
            }
            while (!isOk);

            return flights;
        }

        public string SetCity()
        {
            string city = "";
            InOutModel.OutputString("Enter  the city ");
            city= InOutModel.InputString();
            return city.ToUpper();
        }

        public int SetFlightNumber()
        {
            int FlightNumber = 0;
            bool isOk = false;
            do
            {
                InOutModel.OutputString("Enter the Flight Number ");
                if (int.TryParse(InOutModel.InputString(), out FlightNumber))
                    isOk = true;
                else
                {
                    InOutModel.OutputString("You Enter the wrong data, try again");
                    continue;
                }
            }
            while (!isOk);
            return FlightNumber;
        }

        public int SetGate()
        {
            int gate = 0;
            bool isOk = false;
            do
            {
                InOutModel.OutputString("Enter the Gate Number (from 1 - to 25) ");
                if (int.TryParse(InOutModel.InputString(), out gate))
                {
                    if (gate >= 1 && gate <= 25)
                        isOk = true;
                }
                else
                {
                    InOutModel.OutputString("You Enter the wrong data, try again");
                    continue;
                }
            }
            while (!isOk);
            return gate;
        }

        public Status SetStatus()
        {
            Status status = 0;
            bool isOk = false;
            string tmpButton = "";
            do
            {
                InOutModel.OutputString(@"What the Flight Status : 
        1 - Canceled 
        2 - Check In
        3 - Gate Closed
        4 - Delayed
        5 - InFlight
        6 - Unknown");
                tmpButton = InOutModel.InputString();
                switch (tmpButton)
                {
                    case "1":
                        status = Status.Canceled;
                        isOk = true;
                        break;
                    case "2":
                        status = Status.Check_In;
                        isOk = true;
                        break;
                    case "3":
                        status = Status.Gate_Closed;
                        isOk = true;
                        break;
                    case "4":
                        status = Status.Delayed;
                        isOk = true;
                        break;
                    case "5":
                        status = Status.In_Flight;
                        isOk = true;
                        break;
                    case "6":
                        status = Status.Unknown;
                        isOk = true;
                        break;
                    default:
                        InOutModel.OutputString("You enter wrong data, please try again ");
                        isOk = false;
                        break;
                }

            }
            while (!isOk);
            //do
            //{
            //    InOutModel.UserOutputString("Enter the Flight Status -  Check_In, Gate_Closed, Arrived, Departed_At,Unknown, Canceled, Expected_At, Delayed, In_Flight ");

            //    if ()
            //        isOk = true;
            //    else
            //    {
            //        InOutModel.UserOutputString("You Enter the wrong data, try again");
            //        continue;
            //    }
            //}
            //while (!isOk);
            //return status;
            return status;
        }

        public char SetTerminal()
        {
            char tmpTerminal = '0';
            bool isOk = false;
            do
            {
                InOutModel.OutputString("Enter Terminal - A B C D");
                if (char.TryParse(InOutModel.InputString().ToUpper(), out tmpTerminal))
                    if ("A B C D".Contains(tmpTerminal))
                        isOk = true;
                    else
                    {
                        InOutModel.OutputString("You enter wrong data, please try again ");
                        isOk = false;
                    }
            }
            while (!isOk);
            return tmpTerminal;
        }

        public DateTime SetDate()
        {
            DateTime tmpDT;
            bool isOk = false;
            do
            {
                InOutModel.OutputString("Enter Date and Time (dd-mm-yy hh:mm ");
                if (DateTime.TryParse(InOutModel.InputString(), out tmpDT))
                {
                    if (tmpDT >= DateTime.Now.AddMinutes(30))
                        isOk = true;
                }
                else
                {
                    InOutModel.OutputString("You enter wrong data, please try again ");
                    isOk = false;
                }
            }
            while (!isOk);
            return tmpDT;
        }

        public RaceType EditFlightRace()
        {
            string tmpButton = "";
            RaceType tmpRaceType = RaceType.Arrival;
            bool isOk = false;
            do
            {
                InOutModel.OutputString(" Choose Race type Arrival (1) or Departure (2)");
                tmpButton = InOutModel.InputString();
                switch (tmpButton)
                {
                    case "1":
                        tmpRaceType = RaceType.Arrival;
                        isOk = true;
                        break;
                    case "2":
                        tmpRaceType = RaceType.Departure;
                        isOk = true;
                        break;
                    default:
                        InOutModel.OutputString("You enter wrong data, please try again ");
                        isOk = false;
                        break;
                }
            }
            while (!isOk);
            return tmpRaceType;
        }

        public decimal SetEconomPrice()
        {
            decimal economPrice = 0;
            bool isOk = false;
            do
            {
                InOutModel.OutputString("Enter the Flight econom price  ");
                if (decimal.TryParse(InOutModel.InputString(), out economPrice))
                    isOk = true;
                else
                {
                    InOutModel.OutputString("You Enter the wrong data, try again");
                    continue;
                }
            }
            while (!isOk);
            return economPrice;
        }

        public decimal SetBuissnesPrice()
        {
            decimal buissnesPrice = 0;
            bool isOk = false;
            do
            {
                InOutModel.OutputString("Enter the Flight buissnes price ");
                if (decimal.TryParse(InOutModel.InputString(), out buissnesPrice))
                    isOk = true;
                else
                {
                    InOutModel.OutputString("You Enter the wrong data, try again");
                    continue;
                }
            }
            while (!isOk);
            return buissnesPrice;
        }

        public void DisplayFlights(ICollection<Flight> flights)
        {
            InOutModel.OutputString(@"                                                                                ||            Price        ||");
            InOutModel.OutputString(@"--------------------------------------------------------------------------------||-------------------------||");
            InOutModel.OutputString(@"           ||  № ||   Date   || Time||     City     ||Terminal||Gate||  Status  ||      Econom || Buissnes ||");
            InOutModel.OutputString(@"           ||    ||          ||     ||              ||        ||    ||          ||             ||          ||");
            InOutModel.OutputString(@"-----------||----||----------||-----||--------------||--------||----||----------||-------------||----------||");
            flights.OrderBy(f => f.Date);
            foreach (Flight flight in flights)
            {
                if (flight != null)
                {
                    InOutModel.OutputString(flight.ToString());
                }
            }
        }
    }
}
