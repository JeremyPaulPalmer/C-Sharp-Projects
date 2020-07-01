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
            newEmployee.Id = 0;
            newEmployee.SayName();

            Employee nextEmployee = new Employee();
            nextEmployee.firstName = "John";
            nextEmployee.lastName = "Doe";
            nextEmployee.Id = 1;
            nextEmployee.SayName();
            
            IQuittable quittable = new Employee();
            quittable.Quit();

            if (newEmployee.Id == nextEmployee.Id)
                Console.WriteLine("An error has occurred. Two employees cannot have the same Employee ID.");

            Console.WriteLine(newEmployee.Id);
            Console.WriteLine(nextEmployee.Id);
            Console.ReadLine();
        }
    }
}
