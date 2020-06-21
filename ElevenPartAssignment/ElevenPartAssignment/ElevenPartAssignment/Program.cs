using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] statements = { "The cow jumped through the ", "The grey fox ate the ", "The calico cat lived in a ", "In Japan, people eat a lot of ", "Your favorite food is " };
        Console.WriteLine("Jeremy's Adlibs");
        Console.WriteLine("Please enter a noun.");
        string noun = Console.ReadLine();

        for (int i = 0; i < statements.Length; i++)
        {
            Console.WriteLine(statements[i] + noun + ".");
        }
        Console.ReadLine();

        //for (int i = 0; ;)
        //{
        //    Console.WriteLine(statements[i] + noun);
        //}

        for (int i = 0; i < statements.Length; i++)
        {
            Console.WriteLine(statements[i] + noun);
        }
        Console.ReadLine();

        for (int i = 0; i <= statements.Length - 1; i++)
        {
            Console.WriteLine(statements[i] + noun);
        }
        Console.ReadLine();

        List<string> names = new List<string>() { "Jeremy", "Jesse", "Susan", "Susanne", "Caliel", "Bob", "Jesus", "Javier", "Jimmy", "Jim" };
        Console.WriteLine("Please enter a name:");
        string inputName = Console.ReadLine();
        bool correctName = false;

        
        do
        {
            foreach (string name in names)
            {
                if (name == inputName)
                {
                    Console.WriteLine(name + " is on the list.");
                    correctName = true;
                    break;
                }

                else if (name != inputName)
                {
                    Console.WriteLine(inputName + " is not on the list. Please enter another name.");
                    inputName = Console.ReadLine();
                }
            }
        }
        while (!correctName);
        Console.ReadLine();
    }
}