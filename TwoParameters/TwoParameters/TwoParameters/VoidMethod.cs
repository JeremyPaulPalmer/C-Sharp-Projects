using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParameters
{
    class VoidMethod
    {
        public void TwoIntegers (int int1, int int2)
        {
            int int3 = int1 + 65;
            Console.WriteLine("The first number, " + int1 + ", plus 65 equals " + int3 + ".");
            Console.WriteLine("The second nuber is " + int2 + ".");
        }
    }
}
