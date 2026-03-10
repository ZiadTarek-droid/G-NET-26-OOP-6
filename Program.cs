using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.ComponentModel;
using System.Security.Claims;
using System.Xml.Linq;

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
    }
    }
}
