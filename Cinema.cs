using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
            Console.WriteLine("Projector ON");
        }

        public void Close()
        {
            Console.WriteLine("Projector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }
    }
}
