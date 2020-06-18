using System;


namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            string hourRate = Console.ReadLine();
            decimal hourlyRate = Convert.ToDecimal(hourRate);
            Console.WriteLine("Hours worked per week?");
            string weekHours = Console.ReadLine();
            decimal weeklyHours = Convert.ToDecimal(weekHours);
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            string hourRate2 = Console.ReadLine();
            decimal hourlyRate2 = Convert.ToDecimal(hourRate2);
            Console.WriteLine("Hours worked per week?");
            string weekHours2 = Console.ReadLine();
            decimal weeklyHours2 = Convert.ToDecimal(weekHours2);
            Console.WriteLine("Annual Salary of Person 1:");
            decimal yearlyWage = (hourlyRate * weeklyHours * 52);
            Console.WriteLine(yearlyWage);
            Console.WriteLine("Annual Salary of Person 2:");
            decimal yearlyWage2 = (hourlyRate2 * weeklyHours2 * 52);
            Console.WriteLine(yearlyWage2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(yearlyWage > yearlyWage2);
            Console.ReadLine();

        }
    }
}
