using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");

        Activity main = new Activity();

        main.SetOpenMessage("Welcome to the Relaxation Lounge.\n\nThe following is a list of activities that are designed to help relieve stress and increase mindfulness. Where would you like to start?");

        Console.Write($"{main.GetOpenMessage()}\n\n");

        Console.WriteLine("1. Breathing Control");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Journal Prompts");
        Console.WriteLine("4. Quit\n");

        Console.Write("Please enter your selection: ");
        string userSelection = Console.ReadLine();

        while (userSelection == "1" || userSelection == "2" || userSelection == "3")
        {
             if (userSelection == "1")
            {
                BreathingActivity breath1 = new BreathingActivity();
                Console.WriteLine("");
                breath1.SetName("Breathing Room");
                breath1.DisplayOpenMessage(breath1.GetName());
                Console.WriteLine("");

                breath1.SetDescription("In this activity, you will be prompted to breathe in and out for 5 seconds each time. Follow the prompts and exhale all that stress.");

                Console.WriteLine(breath1.GetDescription());
                
                Console.Write("How many seconds would you like to participate in this activity for? ");
                string userSeconds = Console.ReadLine();
                int seconds = int.Parse(userSeconds);
                breath1.SetDuration(seconds);

                breath1.BreathingExercise(breath1.GetDuration());

                breath1.DisplayEndMessage(breath1.GetName(), breath1.GetDuration());
            }

            else if (userSelection == "2")
            {
                
            }
        }

       
    }
}