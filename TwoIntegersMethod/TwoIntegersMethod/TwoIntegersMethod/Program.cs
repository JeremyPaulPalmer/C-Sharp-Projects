using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegersMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            int userInt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second whole number (optional):");

            TwoIntegers myTwoIntegers = new TwoIntegers();
            int userInt2;
            int result;
            if(int.TryParse(Console.ReadLine(), out userInt2))
            {
                result = myTwoIntegers.TwoInts(userInt1, userInt2);
            }
            else
            {
                result = myTwoIntegers.TwoInts(userInt1);
            }
            
            Console.WriteLine(userInt1 + " plus " + userInt2 + " plus 65 equals " + result + ".");
            Console.ReadLine();
        }
    }
}
