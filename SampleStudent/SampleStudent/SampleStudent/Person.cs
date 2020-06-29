using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStudent
{
    public class Person
    {
        public string firstname;
        public string lastname;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public void SayName()
        {
            Console.WriteLine("Name: " + firstname + " " + lastname);
        }
    }
}
