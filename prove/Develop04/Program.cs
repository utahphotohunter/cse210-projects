using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");

        Activity main = new Activity();
        BreathingActivity breath1 = new BreathingActivity();
        ReflectionActivity reflection1 = new ReflectionActivity();
        ListingActivity listing1 = new ListingActivity();
        

        main.SetOpenMessage("Welcome to the Relaxation Lounge.\n\nThe following is a list of activities that are designed to help relieve stress and increase mindfulness. Where would you like to start?");

        Console.Write($"{main.GetOpenMessage()}\n\n");

        string userSelection = "0";

        while (userSelection != "4")
        {
            Console.WriteLine("1. Breathing Control");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Gratitude Journaling");
            Console.WriteLine("4. Quit\n");

            Console.Write("Please enter your selection: ");
            string userResponse = Console.ReadLine();
            userSelection = userResponse;


            if (userSelection == "1")
            {
                Console.WriteLine("");
                breath1.SetName("Breathing Activity");
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
                
                Thread.Sleep(2000);
                Console.Clear();
            }

            else if (userSelection == "2")
            {
                Console.WriteLine("");
                reflection1.SetName("Reflection Activity");
                reflection1.DisplayOpenMessage(reflection1.GetName());
                Console.WriteLine("");

                reflection1.SetDescription("In this activity, you will be given a prompt to think about. Then, questions relating to this prompt will appear one by one. All you need to do is quietly think of responses to those questions. This will help you focus on some positive aspects of you life. Enjoy!");

                Console.WriteLine(reflection1.GetDescription());
                Console.WriteLine("");

                Console.Write("How many seconds would you like to participate in this activity for? ");
                string userSeconds = Console.ReadLine();
                int seconds = int.Parse(userSeconds);
                reflection1.SetDuration(seconds);

                reflection1.ReflectionExercise(seconds, reflection1.GetPromptList(), reflection1.GetQuestionList()); 

                reflection1.DisplayEndMessage(reflection1.GetName(), reflection1.GetDuration());
                
                Thread.Sleep(2000);
                Console.Clear();
            }

            else if (userSelection == "3")
            {
                Console.WriteLine("");
                listing1.SetName("Gratitude Journaling");
                listing1.DisplayOpenMessage(listing1.GetName());
                Console.WriteLine("");

                listing1.SetDescription("In this activity, you will be given a random prompt to think about for a few seconds and then list as many things as you can in response to the prompt. This can help you see how much there is to be grateful for in the world and help develop a positive mindset.");

                Console.WriteLine(listing1.GetDescription());
                Console.WriteLine("");

                Console.Write("How many seconds would you like to participate in this activity for? ");
                string userSeconds = Console.ReadLine();
                int seconds = int.Parse(userSeconds);
                listing1.SetDuration(seconds);

                listing1.ListingExercise(seconds, listing1.GetPromptsList(), listing1.GetResponseList());

                listing1.DisplayEndMessage(listing1.GetName(), listing1.GetDuration());
                
                Thread.Sleep(2000);
                Console.Clear();


            }

            else
            {
                Console.Clear();
                Console.WriteLine("Have a wonderful day, and remember to be mindful!");
                Console.WriteLine("");
            }
        }

       
    }
}