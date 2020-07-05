using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        //class EmployeeList
        //{
        //    List<Employee> listEmployees = new List<Employee>();

        //    public bool AddEmployee(string firstname, string lastname, int id)
        //    {
        //        listEmployees.Add(new Employee { firstName = firstname, lastName = lastname, Id = id });
        //        return true;
        //    }
        //}

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { firstName = "Sample", lastName = "Employee", Id = 00 },
                new Employee { firstName = "Joe", lastName = "Dirt", Id = 01 },
                new Employee { firstName = "John", lastName = "Doe", Id = 02 },
                new Employee { firstName = "Billy", lastName = "Madison", Id = 03 },
                new Employee { firstName = "Ace", lastName = "Ventura", Id = 04 },
                new Employee { firstName = "Joe", lastName = "Blow", Id = 05 },
                new Employee { firstName = "Harry", lastName = "Krishna", Id = 06 },
                new Employee { firstName = "Baba", lastName = "Ganoosh", Id = 07 },
                new Employee { firstName = "Doctor", lastName = "Dre", Id = 08 },
                new Employee { firstName = "Luigi", lastName = "Mario", Id = 09 }
            };

            List<Employee> Joeployees = new List<Employee>();
            
            foreach (var employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    Joeployees.Add(new Employee { firstName = employee.firstName, lastName = employee.lastName, Id = employee.Id });
                }
            }
            foreach (var item in Joeployees) Console.WriteLine(item.firstName + " " + item.lastName);

            //Employee<string> listEmployees = new Employee<string>();

            //listEmployees.employees.Add(new Employee<string> { firstName = firstname, lastName = lastname });

            //foreach (string i in listEmployees.things)
            //{
            //    Console.WriteLine(i);
            //}

            //Employee<int> intEmployees = new Employee<int>();
            //intEmployees.things = new List<int>() { 18, 22, 56, 43, 99, 15 };

            //foreach (int i in intEmployees.things)
            //{
            //    Console.WriteLine(i);
            //}


            //List<List<string>> listEmployees = new List<List<string>>();
            //listEmployees.Add(new List<string> { newEmployee01 });

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
