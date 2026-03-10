using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Ticket
    {
        public int Id { get; set; }
        public string Movie { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; private set; }

        public Ticket(int id, string movie, double price)
        {
            Id = id;
            Movie = movie;
            Price = price;
        }

        // Abstract method
        public abstract double CalculateFinalPrice();

        // Virtual method
        public virtual string Type()
        {
            return "Ticket";
        }

        // Concrete method
        public void Book()
        {
            IsBooked = true;
        }

        public void Cancel()
        {
            IsBooked = false;
        }
    }
}
