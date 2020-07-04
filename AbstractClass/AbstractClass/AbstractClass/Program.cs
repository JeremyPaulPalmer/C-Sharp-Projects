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
            Employee<string> listEmployees = new Employee<string>();
            listEmployees.things = new List<string>() { "Jeremy", "Jesse", "Andy", "Ben" };
            
            foreach (string i in listEmployees.things)
            {
                Console.WriteLine(i);
            }

            Employee<int> intEmployees = new Employee<int>();
            intEmployees.things = new List<int>() { 18, 22, 56, 43, 99, 15 };

            foreach (int i in intEmployees.things)
            {
                Console.WriteLine(i);
            }


            //Employee newEmployee = new Employee();
            //newEmployee.firstName = "Sample";
            //newEmployee.lastName = "Employee";
            //newEmployee.Id = 0;
            //newEmployee.SayName();

            //Employee nextEmployee = new Employee();
            //nextEmployee.firstName = "John";
            //nextEmployee.lastName = "Doe";
            //nextEmployee.Id = 1;
            //nextEmployee.SayName();
            
            //IQuittable quittable = new Employee();
            //quittable.Quit();

            //if (newEmployee.Id == nextEmployee.Id)
            //    Console.WriteLine("An error has occurred. Two employees cannot have the same Employee ID.");

            //Console.WriteLine(newEmployee.Id);
            //Console.WriteLine(nextEmployee.Id);
            Console.ReadLine();
        }
    }
}
