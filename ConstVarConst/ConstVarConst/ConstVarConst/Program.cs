using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarConst
{
    class Program
    {
        const string creator = "Jeremy";
        static void Main(string[] args)
        {
            var constructor = new Constructor(creator);
        }
    }
}
