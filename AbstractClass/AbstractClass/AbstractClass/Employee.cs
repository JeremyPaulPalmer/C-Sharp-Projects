using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //public List<T> employees { get; set; }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("This is an example of calling a method from an interface.");
        }

        //public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        //{
        //    bool status = false;
        //    if (employeeOne.Id == employeeTwo.Id)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}
        //public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        //{
        //    bool status = false;
        //    if (employeeOne.Id != employeeTwo.Id)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}
    }
}
