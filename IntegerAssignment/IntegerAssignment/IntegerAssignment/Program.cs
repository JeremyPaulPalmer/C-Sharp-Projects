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
            int outInt;
            Console.WriteLine("Please choose a whole number to perform math operations on:");
            int userInt = Convert.ToInt32(ReadLine());
            ThreeMathMethods three = new ThreeMathMethods();
            three.Addition(userInt);
            three.Addition(out outInt);
        }
    }
}
