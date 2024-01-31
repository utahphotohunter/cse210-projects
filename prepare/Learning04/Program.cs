using System;

class Program
{
    static void Main(string[] args)
    {


        Assignment assignment1 = new Assignment();

        Console.WriteLine("\n");
        Console.WriteLine($"{assignment1.GetSummary()}\n");


        MathAssignment mathAssignment1 = new MathAssignment();

        mathAssignment1.SetStudentName("Robert Edward");
        mathAssignment1.SetTopic("Spanish Conquest");

        Console.WriteLine($"{mathAssignment1.GetHomeworkList("6.1.5", "7-9")}\n");


        WritingAssignment writingAssignment1 = new WritingAssignment();

        writingAssignment1.SetStudentName("Daisy Sorenson");
        writingAssignment1.SetTopic("Ancient Civilizations and Modern Impacts");

        Console.WriteLine($"{writingAssignment1.GetWritingInformation("Roman History and the Holy Bible")}\n");

        WritingAssignment writingAssignment2 = new WritingAssignment();
        writingAssignment2.SetTitle("The Holy Grail's Legacy in Modern Schools");
        writingAssignment2.SetStudentName("Joe Rogan");
        writingAssignment2.SetTopic("The Holy Grail's Secret Technology");

        Console.WriteLine($"{writingAssignment2.GetWritingInformation()}\n");


    }
}