using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        float userNumber = PromptUserNumber();
        double squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }





    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    static float PromptUserNumber()
    {
        Console.Write("What is your favorite Number? ");
        string userNumber = Console.ReadLine();
        float number = float.Parse(userNumber);
        return number;
    }
    static double SquareNumber(float number)
    {
        double result = Math.Pow(number, 2);
        return result;
    }
    static void DisplayResult(string userName, double squaredNumber)
    {
        string textVersion = squaredNumber.ToString();
        Console.Write($"{userName} your number squared is {textVersion}.");
    }
}