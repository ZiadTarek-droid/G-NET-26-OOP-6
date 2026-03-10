using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.ComponentModel;
using System.Security.Claims;
using System.Xml.Linq;
using System.IO;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Threading;
using static System.Net.WebRequestMethods;
using System.Data.Common;
using System.Net.Sockets;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Abstraction

            //Abstraction means hiding complex implementation details and showing only the essential features of an object.

            //It focuses on what the object does, not how it does it.

            //Abstraction is usually implemented using:

            //Abstract classes

            //Interfaces

            //Encapsulation

            //Encapsulation means wrapping data and methods together in a single unit(class) and controlling access to the data using access modifiers like:

            //private
            //    protected
            //    public

            //Encapsulation focuses on protecting data from direct access.

            //Difference
            //Abstraction Encapsulation
            //Hides implementation details Hides internal data
            //Focuses on behavior Focuses on data protection
            //Implemented using abstract classes and interfaces Implemented using access modifiers
            //Shows only necessary functionality Controls access to variables
            //Real World Example

            //ATM Machine

            //When using an ATM:

            //You only see options like:

            //Withdraw

            //Deposit

            //Check balance

            //You don't see how the bank system processes transactions internally.

            //That is Abstraction.

            //Inside the ATM system, your account balance is private and can only be accessed through methods like Withdraw() or Deposit().

            //That is Encapsulation.
            #endregion

            #region Q2
            //    Methods Implementation

            //Abstract Class

            //Can contain abstract and normal methods

            //Interface

            //Contains method declarations only(until newer C# versions)

            //Fields / Variables

            //Abstract Class

            //Can have fields and properties.

            //Interface

            //Cannot have fields.

            //Constructors

            //Abstract Class

            //Can have constructors.

            //Interface

            //Cannot have constructors.

            //Inheritance

            //Abstract Class

            //A class can inherit only one abstract class

            //Interface

            //A class can implement multiple interfaces

            //When to use each?

            //Use Abstract Class when:

            //Classes share common behavior and code

            //You want some methods implemented

            //Use Interface when:

            //You want to define a contract

            //Multiple classes must implement the same behavior

            //You need multiple inheritance
            #endregion

            #region Q3
            //Appliance a = new Appliance("LG");

            // No, this is not allowed.

            //Because Appliance is an abstract class.

            //Abstract classes cannot be instantiated directly.
            //They are meant to be used as base classes for other classes.

            //b)

            //Difference between the methods:

            //1-PowerConsumption()
            //public abstract double PowerConsumption();

            //        Abstract method

            //Has no implementation

            //Must be implemented by child classes

            //Reason:
            //Each appliance consumes different power.

            //2- Status()
            //public virtual string Status() => "Standby";

            //        Virtual method

            //Has default implementation

            //Child classes can override it

            //Reason:
            //Most appliances might start in Standby, but some may change the behavior.

            //3-Label()
            //public string Label() => $"{Brand} - {PowerConsumption()}W";

            //        Concrete method

            //Already implemented

            //Child classes do not need to override

            //Reason:
            //All appliances can use the same label format.

            //c)

            //If we call:

            //Status()

            //on a Toaster object.

            //It will return:

            //Standby

            //Because:

            //Toaster does not override Status()

            //So it uses the base implementation from Appliance
            #endregion

            #region Q4

            //a) What is a partial class?

            //A partial class allows a class definition to be split across multiple files.

            //Example:

            //Calculator.cs
            //Calculator.Logging.cs

            //Both together create one class called Calculator.

            //Why use it?

            //To:

            //Organize large classes

            //Separate responsibilities

            //Allow multiple developers to work on the same class

            //b) What is a partial method?

            //A partial method is a method that:

            //is declared in one part of a partial class

            //implemented in another file

            //Example:

            //partial void OnCalculated(double result);

            //        If the implementation is deleted, the code will:

            // Still compile

            //Because the compiler removes the method call automatically.

            //c) What is an extension method?

            //An extension method allows adding new methods to an existing class without modifying its source code.

            //Example:

            //result.ToCurrency()

            //Even though double doesn't originally contain ToCurrency().

            //Three rules for extension methods

            //1-Must be inside a static class

            //2-The method itself must be static

            //3-The first parameter must use the this keyword

            //Example:

            //public static string ToCurrency(this double value)
            //d) Output of the code

            //Code:

            //Calculator calc = new Calculator();
            //        double result = calc.Add(19.5, 0.5);
            //        Console.WriteLine(result.ToCurrency());

            //Step 1

            //19.5 + 0.5 = 20

            //Step 2

            //OnCalculated() prints:

            //Log: result = 20

            //Step 3

            //ToCurrency() formats the number:

            //$20.00
            //Final Output
            //Log: result = 20
            //$20.00
            #endregion
            #region PART02
            Console.WriteLine();

            // Ticket t = new Ticket("Test",100);
            // ERROR: Cannot create instance of abstract class Ticket

            Cinema cinema = new Cinema();

            cinema.Open();

            StandardTicket t1 = new StandardTicket(1, "Inception", 80, "A5");
            VIPTicket t2 = new VIPTicket(2, "Avengers", 200, true, 50);
            IMAXTicket t3 = new IMAXTicket(3, "Dune", 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintTickets();

            Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");

            Ticket[] arr = { t1, t2, t3 };

            foreach (var t in arr)
            {
                Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
            }

            Console.WriteLine("\n--- Extension Method: Receipt ---");
            Console.WriteLine(t2.GenerateReceipt());

            Console.WriteLine("\n--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {arr.TotalRevenue():F2}");

            cinema.Close();
            #endregion
        }
    }
}
