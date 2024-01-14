using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your percentage in the class? ");
        string grade = Console.ReadLine();
        float numberGrade = float.Parse(grade);
        
        string letter = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (letter == "F" || letter == "D")
        {
            Console.WriteLine($"Unfortunatley, you received a {letter} and did not pass the class. Consider studying harder next attempt.");
        }
        else if (letter == "A")
        {
            Console.WriteLine($"You passed the class with an {letter}!");
        }
        else
        {
            Console.WriteLine($"You passed the class with {letter}!");
        }
        
        
    }
}