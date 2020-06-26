using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntegerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a whole number to perform math operations on:");
            int userInt = Convert.ToInt32(Console.ReadLine());
            ThreeMathMethods three = new ThreeMathMethods();
            three.Addition(userInt, out int addInt);
            Console.WriteLine(userInt + " plus " + userInt + " equals " + addInt + ".");
            three.Multiplication(userInt, out int multInt);
            Console.WriteLine(userInt + " times " + userInt + " equals " + multInt + ".");
            three.Division(userInt, out int divInt);
            Console.WriteLine(userInt + " divided by " + userInt + " equals " + divInt + ".");
            Console.ReadLine();
        }
    }
}
