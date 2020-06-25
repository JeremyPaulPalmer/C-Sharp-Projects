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
        public static void Addition()
        {
            int addInt = userInt + userInt;
        }
    }
}
