using AirlineApp.Enums;
using AirlineApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models
{
    public interface IFabricMethod
    {

    }
    public class Flight
    {
        public RaceType RaceType { get; set; }
        public int FligthNumber { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public int Gate { get; set; }
        public char Terminal { get; set; }
        public decimal EconomPrice { get; set; }
        public decimal BuissnesPrice { get; set; }

        IEnumerable<Passenger> Passengers;
        public Flight()
        {
            Passengers = new List<Passenger>();
        }
        public Flight(RaceType raceType, int flightNumber, Status status, DateTime date, string city, int gate,
                                                        char terminal, decimal economPrice, decimal buissnesPrice)
        {
            Passengers = new List<Passenger>();
            RaceType = raceType;
            FligthNumber = flightNumber;
            Status = status;
            Date = date;
            City = city;
            Gate = gate;
            Terminal = terminal;
            EconomPrice = economPrice;
            BuissnesPrice = buissnesPrice;
        }

        public override string ToString()
        {
            return String.Format("||{0,9}||{1,4}||{2,10}||{3,5}||{4,14}||{5,8}||{6,4}||{7,10}||{8,10}||{9,10}", RaceType, FligthNumber, Date.ToShortDateString(),
                                                                                                  Date.ToShortTimeString(), City, Terminal, Gate, Status,
                                                                                                  EconomPrice, BuissnesPrice);
        }
    }
}
