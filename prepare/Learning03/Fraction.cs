

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

public class Fraction
//creates Fraction class
{
    private int _topNumber;
    // creates private member _topNumber for Fraction class
    private int _bottomNumber;
    //creates private member _bottomNumber for Fraction class

    public int GetTop()
    //returns the numerator of the fraction
    {
        int topNumber = _topNumber;
        return topNumber;
    }

    public int GetBottom()
    //returns the denominator of the fraction
    {
        int bottomNumber = _bottomNumber;
        return bottomNumber;
    }

    public int SetTop()
    //allows the user to set the numerator of a fraction
    {
        Console.Write("What would you like the top number to be? ");
        string userTop = Console.ReadLine();
        int result = int.Parse(userTop);
        return result;
    }

     public int SetBottom()
     //allows the user to set the denominator of a fraction
    {
        Console.Write("What would you like the bottom number to be? ");
        string userBottom = Console.ReadLine();
        int result = int.Parse(userBottom);
        return result;
    }

    public Fraction()
    //general constructor. creates default output of 1/1
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int wholeNumber)
    //uses the numerator given by the user as the numerator in a fraction. Sets the denominator to 1
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    //uses the numerator given by user and denominator given by user to make a fraction
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public string GetFraction()
    //returns a fraction written in a string in a numerator / denominator format - example: x/y
    {
        string topText = _topNumber.ToString();
        string bottomText = _bottomNumber.ToString();
        string result = $"{topText}/{bottomText}";
        return result;
    }

    public double GetDecimal()
    //returns a fraction as a decimal by dividing the numerator by the denominator
    {
        double result = (double)_topNumber/(double)_bottomNumber;
        return result;
    }
}