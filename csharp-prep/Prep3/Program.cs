using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Random randomNumber = new Random();
        int number = randomNumber.Next(1,100);
        Console.WriteLine("I am thinking of a number between 1 and 100.");
        int finalGuess = 0;
        while (finalGuess != number)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessedNumber = int.Parse(guess);
            finalGuess = guessedNumber;
            if (guessedNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessedNumber > number)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}