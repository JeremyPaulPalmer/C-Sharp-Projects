using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ACME Insurance!");
            Console.WriteLine("Please answer the following question to determine coverage:");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            byte inAge = Convert.ToByte(age);
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            string DUI = Console.ReadLine();
            bool inDUI = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedTix = Console.ReadLine();
            byte inTix = Convert.ToByte(speedTix);
            Console.WriteLine("Based on you answers, can ACME insurance provide you coverage?");
            Console.WriteLine(inAge > 15 && inDUI == false && inTix <= 3);
            Console.ReadLine();


            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(fales == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);
        }
    }
}
