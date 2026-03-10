using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Cinema
    {
        public void PrintTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (var t in tickets)
            {
                Console.WriteLine(
                    $"[Ticket #{t.Id}] {t.Movie} | {t.Type()} | Price: {t.Price} | Final: {t.CalculateFinalPrice():F2} | Booked: {t.IsBooked}"
                );
            }
        }
    }
}
