using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    public enum daysOftheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week:");
                string userDay = Console.ReadLine();
                daysOftheWeek newDay = (daysOftheWeek)Enum.Parse(typeof(daysOftheWeek), userDay);
                Console.WriteLine("Thank you! Have a great " + userDay + "!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week or check your spelling.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    
}
