using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidStaticMethod
{
    class VoidMethod
    {
        public void voidMethod(int userInt, out int outInt)
        {
            outInt = userInt / 2;
        }
        
        public void voidMethod(decimal userInt2, out decimal outInt2)
        {
            outInt2 = userInt2 * 2;
        }
    }
}
