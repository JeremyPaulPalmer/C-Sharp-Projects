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
            Console.WriteLine("Please enter a whole number:");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Jeremy Palmer\Desktop\C_Sharp_Projects\userinput.txt", text);
            Console.WriteLine("\nYou entered:");
            Console.WriteLine(File.ReadAllText(@"C:\Users\Jeremy Palmer\Desktop\C_Sharp_Projects\userinput.txt"));
            Console.ReadLine();
        }
    }
}
