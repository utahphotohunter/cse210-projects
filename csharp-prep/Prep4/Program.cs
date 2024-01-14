using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            string newEntry = Console.ReadLine();
            newNumber = int.Parse(newEntry);
            numbers.Add(newNumber);
        }
        int total = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();
        Console.WriteLine($"The sum of all the numbers is {total}.");
        Console.WriteLine($"The average of all the numbers is {average}.");
        Console.WriteLine($"The largest of all the numbers is {largest}.");
        

    }
}