using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] stringArray = { "Hello", "Goodbye", "Hola", "Hasta la bye bye", "Moshi Moshi" };
        Console.WriteLine("Jeremy's String Theory");
        Console.WriteLine("Please choose a number between 0 and 4.");
        int index = Convert.ToInt32(Console.ReadLine());

        if (index < 0 || index > 4)
        {
            Console.WriteLine("That is not a number between 0 and 4! Please pay attention and try again!");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[index]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(stringArray[index]);
            Console.ReadLine();
        }

        int[] intArray = { 18, 32, 83, 49, 52 };
        Console.WriteLine("Fun with numbers!");
        Console.WriteLine("Please choose a number between 0 and 4.");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0 || number > 4)
        {
            Console.WriteLine("That is not a number between 0 and 4! Please pay attention and try again!");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intArray[number]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(intArray[number]);
            Console.ReadLine();
        }

        List<string> stringList =  new List<string> { "Cow", "Horse", "Pig", "Duck", "Goose" };
        Console.WriteLine("Jeremy's String Theory #2");
        Console.WriteLine("Please choose a number between 0 and 4.");
        int animals = Convert.ToInt32(Console.ReadLine());

        if (animals < 0 || animals > 4)
        {
            Console.WriteLine("That is not a number between 0 and 4! Please pay attention and try again!");
            animals = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[animals]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(stringList[animals]);
            Console.ReadLine();
        }



        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

