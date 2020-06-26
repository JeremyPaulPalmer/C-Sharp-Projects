using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int staticInt = 53;
            decimal staticDec = 57.25M;
            string staticStr = "3";
            Overload myOverload = new Overload();
            myOverload.sameName(staticInt, out int addInt);
            Console.WriteLine(staticInt + " plus 29 equals " + addInt + ".");
            myOverload.sameName(staticDec, out int decInt);
            Console.WriteLine(staticDec + " minus 19.75 equals " + decInt + ".");
            myOverload.sameName(staticStr, out int strInt);
            Console.WriteLine(staticStr + " multiplied by 63 equals " + strInt + ".");
            Console.ReadLine();
        }
    }
}
