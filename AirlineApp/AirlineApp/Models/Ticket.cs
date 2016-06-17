using AirlineApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models
{
    class Ticket
    {
        TicketType TicketType { get; set; }
        decimal Price { get; set; }
        public Ticket(TicketType ticketType, decimal price)
        {
            TicketType = ticketType;
            Price = price;
        }
    }
}
