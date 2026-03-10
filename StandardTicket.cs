using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(int id, string movie, double price, string seat)
            : base(id, movie, price)
        {
            Seat = seat;
        }

        public override double CalculateFinalPrice()
        {
            return Price * 1.14;
        }

        public override string Type()
        {
            return "Standard";
        }
    }
}
