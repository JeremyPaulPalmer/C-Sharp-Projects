using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a random number:");
            string randomNumber = Console.ReadLine();
            int ranNum = Convert.ToInt32(randomNumber);
            Console.WriteLine("Your number times 50 = " + ranNum * 50);
            Console.WriteLine("Your number plus 25 = " + ranNum + 25);
            Console.WriteLine("Your number divide by 12.5 = " + ranNum / 12.5);
            Console.WriteLine("Is your number greater than 50? "  + (ranNum > 50));
            Console.WriteLine("The remainder of your number divided by 7 = " + ranNum % 7);
            Console.ReadLine();
            
            
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 68;

            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();
        }
    }
}
