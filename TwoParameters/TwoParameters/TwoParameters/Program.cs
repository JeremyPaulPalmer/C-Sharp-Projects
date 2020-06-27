using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 25;
            int int2 = 32;
            VoidMethod myVoidMethod = new VoidMethod();
            myVoidMethod.TwoIntegers(int1, int2);
            Console.ReadLine();
        }
    }
}
