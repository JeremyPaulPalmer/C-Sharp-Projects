using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a whole number:");
            //string text = Console.ReadLine();
            //File.WriteAllText(@"C:\Users\Jeremy Palmer\Desktop\C_Sharp_Projects\userinput.txt", text);
            //Console.WriteLine("\nYou entered:");
            //Console.WriteLine(File.ReadAllText(@"C:\Users\Jeremy Palmer\Desktop\C_Sharp_Projects\userinput.txt"));
            //Console.ReadLine();

            //DateTime yearOfBirth = new DateTime(1995, 5,23, 8, 32,45);
            //DateTime yearOfGrad = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGrad = yearOfGrad - yearOfBirth;

            //using (StreamWriter file = new StreamWriter(@"C:\Users\Jeremy Palmer\Desktop\C_Sharp_Projects\log.txt", true))
            //{
            //    file.WriteLine(DateTime.Now);
            //}

            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date and time is:");
            Console.WriteLine(currentTime);
            Console.WriteLine("Please enter a whole number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + x + " hours, the time will be:");
            DateTime xHoursLater = currentTime.AddHours(x);
            Console.WriteLine(xHoursLater);
            Console.ReadLine();
        }
    }
}
