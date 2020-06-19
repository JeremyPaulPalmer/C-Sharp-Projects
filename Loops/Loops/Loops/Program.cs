using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature inside?");
            int temp = Convert.ToInt32(Console.ReadLine());
            bool inTemp = temp < 70;

            do
            {
                switch (temp)
                {
                    case var expression when temp >= 70:
                        Console.WriteLine("Please turn off the heat.");
                        inTemp = false;
                        break;
                    default:
                        Console.WriteLine("Please turn up the heat.");
                        Console.WriteLine("What is the temperature now?");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (inTemp);

            Console.ReadLine();
            }
    


            //Console.WriteLine("Guess a number.");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 12;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);
           
            //Console.ReadLine();
        }
    }

