using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package in pounds. Please round up.");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a nice day.");
                Console.ReadLine();
            }
            else if (packWeight <= 50)
            {
                Console.WriteLine("What is the length of your package in inches? Please round up.");
                decimal packLength = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the width of your package in inches? Please round up.");
                decimal packWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the height of your package in inches? Please round up.");
                decimal packHeight = Convert.ToDecimal(Console.ReadLine());
                if (packLength + packWidth + packHeight > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal total = ((packLength * packWidth * packHeight * packWeight) / 100);
                    Console.WriteLine("The cost to ship your package is $" + total + ".");
                    Console.ReadLine();
                }
            }

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome." : "You do not have an awesome favorite number.";

            //Console.WriteLine(result);
            //Console.ReadLine();
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh..... something went wrong.");
            //}
            //Console.ReadLine();

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();
        }
    }
}
