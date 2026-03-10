using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(int id, string movie, double price, bool is3D)
            : base(id, movie, price)
        {
            Is3D = is3D;
        }

        public override double CalculateFinalPrice()
        {
            return Price * 1.14;
        }

        public override string Type()
        {
            return "IMAX";
        }
    }
}
