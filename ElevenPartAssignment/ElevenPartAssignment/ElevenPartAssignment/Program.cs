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
            for (int name = 0; name < names.Count; name++)
            {
                if (names[name] == inputName)
                {
                    Console.WriteLine(names[name] + " is on the list.");
                    correctName = true;
                    break;
                }
            }
            if (correctName == true)
            {
                break;
            }
            else
            {
                Console.WriteLine(inputName + " is not on the list. Please enter another name.");
                inputName = Console.ReadLine();
            }
        }
        while (correctName != true);
        Console.ReadLine();

        List<string> animals = new List<string>() { "bird", "cow", "goose", "bird", "cat", "dog", "pig", "horse", "dog", "horse" };
        //Console.WriteLine("Please enter an animal:");
        //string inputAnimal = Console.ReadLine();
        //bool correctAnimal = false;

        //do
        //{
        //    for (int animal = 0; animal < animals.Count; animal++)
        //    {
        //        if (animals[animal] == inputAnimal)
        //        {
        //            Console.WriteLine(animals[animal] + " is located at index " + animal);
        //            correctAnimal = true;
        //        }
        //    }
        //    if (correctAnimal == true)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine(inputAnimal + " is not on the list. Please enter another animal.");
        //        inputAnimal = Console.ReadLine();
        //    }
        //}
        //while (correctAnimal != true);

        List<string> animals2 = new List<string>();
        foreach (string animal in animals)
        {
            if (!animals2.Contains(animal))
            {
                animals2.Add(animal);
                Console.WriteLine("This is the first instance of " + animal + " on the list.");
            }
            else if (animals2.Contains(animal))
            {
                Console.WriteLine("This is a duplicate listing for " + animal + ".");
            }

        }
        Console.ReadLine();
    }
}