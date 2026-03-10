using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public double Fee { get; set; }

        public VIPTicket(int id, string movie, double price, bool lounge, double fee)
            : base(id, movie, price)
        {
            LoungeAccess = lounge;
            Fee = fee;
        }

        public override double CalculateFinalPrice()
        {
            return (Price + Fee) * 1.14;
        }

        public override string Type()
        {
            return "VIP";
        }
    }
}
