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
        class EmployeeList
        {
            public List<Employee> listEmployees = new List<Employee>();

            public bool AddEmployee(string firstname, string lastname, int id)
            {
                listEmployees.Add(new Employee { firstName = firstname, lastName = lastname, Id = id });
                return true;
            }
        }

        static void Main(string[] args)
        {
            var employeeList = new EmployeeList();
            employeeList.AddEmployee("Sample", "Employee", 00);
            employeeList.AddEmployee("Joe", "Dirt", 01);
            employeeList.AddEmployee("John", "Doe", 02);
            employeeList.AddEmployee("Billy", "Madison", 03);
            employeeList.AddEmployee("Ace", "Ventura", 04);
            employeeList.AddEmployee("Joe", "Blow", 05);
            employeeList.AddEmployee("Harry", "Krishna", 06);
            employeeList.AddEmployee("Baba", "Ganoosh", 07);
            employeeList.AddEmployee("Doctor", "Dre", 08);
            employeeList.AddEmployee("Luigi", "Mario", 09);

            var employeeJoeList = new EmployeeList();

            foreach (List<string> employee in employeeList)
            {
                foreach (string item in employee)
                {
                    if (item == "Joe")
                    {
                        employeeJoeList.AddEmployee(item);
                    }
                }
            }

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
