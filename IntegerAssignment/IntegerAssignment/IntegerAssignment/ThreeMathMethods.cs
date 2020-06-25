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
        public int addInt;
        public int multInt;
        public int divInt;
        int userInt = Convert.ToInt32(Console.ReadLine());
        public void Addition()
        {
            addInt = userInt + userInt;
            Console.WriteLine(userInt + " plus " + userInt + " equals " + addInt);
        }
        public void Multiplication()
        {
            multInt = userInt * userInt;
            Console.WriteLine(userInt + " times " + userInt + " equals " + multInt);
        }
        public void Division()
        {
            divInt = userInt / userInt;
            Console.WriteLine(userInt + " divided by " + userInt + " equals " + divInt);
        }
    }
}
