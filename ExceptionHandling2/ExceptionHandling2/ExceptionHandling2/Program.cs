using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Please enter your age in years:");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0) throw new AgeException();
                DateTime currentTime = DateTime.Now;
                DateTime yearOfBirth = currentTime.AddYears(-(userAge));
                Console.WriteLine("You were born in the year of our lord:");
                Console.WriteLine(yearOfBirth.ToString("yyyy"));
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("Please enter a whole number greater than 0, no decimals.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid age.");
                Console.ReadLine();
                return;
            }
        }
    }
}
