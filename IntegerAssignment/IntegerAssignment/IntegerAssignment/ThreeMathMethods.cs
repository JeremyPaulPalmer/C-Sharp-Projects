using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IntegerAssignment
{
    public class ThreeMathMethods
    {
        int userInt = Convert.ToInt32(Console.ReadLine());
        public void Addition(int userInt, out int addInt)
        {
            addInt = userInt + userInt;
        }
        public void Multiplication(int userInt, out int multInt)
        {
            multInt = userInt * userInt;
        }
        public void Division(int userInt, out int divInt)
        {
            divInt = userInt / userInt;
        }
    }
}
