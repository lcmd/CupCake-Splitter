using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupCakeSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            //learning try/catch exceptions

            try // creating try for Divide by zero exception and format exception
            { 
                Console.WriteLine("How many cupcakes do you have?");
            int cupcakes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many people are sharing?");
            int people = int.Parse(Console.ReadLine());

            int cupcakesPerPerson = cupcakes / people; //outright division
            int remainingCupcakes = cupcakes % people; //cupcakes with remainder
        
                Console.WriteLine("Each perosn gets {0} cupcakes, and there are {1} left over.", cupcakesPerPerson, remainingCupcakes);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't split cupcakes with zero people, therefore you the Feds!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number, otherwise you the Feds.");
            }
            finally
            {
                Console.WriteLine("Thanks for playing!");
            }

        }
    }
}
