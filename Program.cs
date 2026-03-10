using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

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
        }
    }
}
