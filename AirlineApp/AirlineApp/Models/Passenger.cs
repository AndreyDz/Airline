using AirlineApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models
{
    class Passenger
    {
        string Name { get; set; }
        string SecondName { get; set; }
        string Nationality { get; set; }
        Gender Gender { get; set; }
        string Passport { get; set; }
        Ticket Ticket { get; set; }
        public Passenger(string name, string secondName, string passport, string nationality, Gender gender, Ticket ticket)
        {
            Ticket = ticket;
            Name = name;
            SecondName = secondName;
            Passport = passport;
            Nationality = nationality;
            Gender = gender;
        }

        void ChangeTicket (Ticket ticket)
        {
            Ticket = ticket;
        }
    }
}
