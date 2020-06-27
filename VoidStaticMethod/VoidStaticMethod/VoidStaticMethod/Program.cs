using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidStaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            int userInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a decimal:");
            decimal userInt2 = Convert.ToDecimal(Console.ReadLine());
            VoidMethod myVoidMethod = new VoidMethod();
            myVoidMethod.voidMethod(userInt, out int outInt);
            Console.WriteLine(userInt + " divided by 2 equals " + outInt + ".");
            myVoidMethod.voidMethod(userInt2, out decimal outInt2);
            Console.WriteLine(userInt2 + " times 2 equals " + outInt2 + ".");
            StaticClass.staticDetails();
            Console.ReadLine();
        }
    }
}
