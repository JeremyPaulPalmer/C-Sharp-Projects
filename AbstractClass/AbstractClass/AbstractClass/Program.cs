using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.firstName = "Sample";
            newEmployee.lastName = "Employee";
            newEmployee.SayName();
            
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
