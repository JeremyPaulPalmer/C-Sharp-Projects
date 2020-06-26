using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Overload
    {
        public void sameName(int staticInt, out int addInt)
        {
            addInt = staticInt + 29;
        }

        public void sameName(decimal staticDec, out int decInt)
        {
            decimal myDec = 19.75M;
            decimal nextDec = staticDec - myDec;
            decInt = Convert.ToInt32(nextDec);
        }

        public void sameName(string staticStr, out int strInt)
        {
            int myInt = 63;
            int nextInt = Convert.ToInt32(staticStr);
            strInt = nextInt * myInt;
            
        }
    }
}
