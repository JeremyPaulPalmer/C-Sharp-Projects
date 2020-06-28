using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStudent
{
    public class Employee : Person
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override void SayName()
        {
            base.SayName();
        }
    }
}
