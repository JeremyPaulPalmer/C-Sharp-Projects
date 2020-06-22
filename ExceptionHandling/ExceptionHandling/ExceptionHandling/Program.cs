using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>() { 5, 10, 9, 3, 12, 18 };

        try
        {
            Console.WriteLine("Please enter a number to divide by:");
            int userInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < integers.Count; i++)
            {
                int answer = integers[i] / userInt;
                Console.WriteLine(integers[i] + " divided by " + userInt + " equals " + answer + ".");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide by zero. It's like crossing streams.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number. Sad thing was, that wasn't even a number much less a whole one.");
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("We have emergethed from the dreaded try/catch block! Program execution may commenceth.");
        Console.ReadLine();
        
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number.");
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}
        //Console.ReadLine();
    }
}

