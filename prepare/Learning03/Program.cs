using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new Fraction();
        //creates new instance of Fraction Class
        double newFractionDecimal = newFraction.GetDecimal();
        //sets a variable to store the newFraction.GetDecimal() function return

        int topNumber = newFraction.SetTop();
        //allows user to provide a numerator and stores it in a variable for later use
        int bottomNumber = newFraction.SetBottom();
        //allows user to provide a denominator and stores it in a variable for later use

        Fraction wholeNumber = new Fraction(topNumber);
        //creates variable to store the return of the Fraction function and uses the user provided numerator as the fraction's numerator. Denominator is set to 1
        double wholeNumberDecimal = wholeNumber.GetDecimal();
        //sets a variable to store the wholeNumber.GetDecimal() function return

        Fraction userDefined = new Fraction(topNumber, bottomNumber);
        //creates variable to store the return of the Fraction function and uses the user provided numerator and denominator as the fraction's numerator and denonimator
        double userDefinedDecimal = userDefined.GetDecimal();
        //sets a variable to store the userDefined.GetDecimal() function return

        //output

        Console.WriteLine(newFraction.GetFraction());
        //displays 1/1
        Console.WriteLine($"{newFractionDecimal:0.00}");
        //displays 1
        Console.WriteLine(wholeNumber.GetFraction());
        //displays user's numerator over 1
        Console.WriteLine($"{wholeNumberDecimal:0.00}");
        //displays the numerator given by user
        Console.WriteLine(userDefined.GetFraction());
        //displays user's numerator over user's denominator
        Console.WriteLine($"{userDefinedDecimal:0.00}");
        //displays the result of dividing the user's numerator by the user's denominator
    }
}