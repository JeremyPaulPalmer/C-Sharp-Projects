using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerContext())
            {
                Console.Write("To receive more information please provide the following information:\n");
                Console.WriteLine("First Name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("\nLast Name: ");
                var lastName = Console.ReadLine();
                Console.WriteLine("\nEmail Address: ");
                var emailAddress = Console.ReadLine();

                var customer = new Customer { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress };
                db.Customers.Add(customer);
                db.SaveChanges();

                var query = from a in db.Customers
                            orderby a.LastName
                            select a;
                Console.WriteLine("All customers in the database:\n");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + "\t" + item.EmailAddress);
                }

                Console.WriteLine("\nPress any key to exit program.");
                Console.ReadKey();
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
