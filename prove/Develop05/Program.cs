using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string userEntry = "0";

        while (userEntry != "6")
        {
            Console.WriteLine("\n");

            Console.WriteLine("Please choose from one of the options below:\n");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit\n");

            Console.Write("Enter a number 1-6: ");
            string userSelection = Console.ReadLine();
            userEntry = userSelection;

            if (userEntry == "1")
            {
                Console.Clear();
                Console.WriteLine("What kind of goal would you like to create?\n");

                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal\n");

                Console.Write("Enter a number 1-3: ");
                string userGoalType = Console.ReadLine();

                if (userGoalType == "1")
                {
                    Console.Clear();
                    SimpleGoal simpleGoal = new SimpleGoal();

                    simpleGoal.SetName();
                    simpleGoal.SetDescription();
                    simpleGoal.SetPoints();
                    List<string> simpleGoal1 = simpleGoal.CreateGoal(simpleGoal.GetName(), simpleGoal.GetDescription(), simpleGoal.GetPoints());
                    goalManager.AddGoal(simpleGoal1);
                }

                else if (userGoalType == "2")
                {
                    Console.Clear();
                    EternalGoal eternalGoal = new EternalGoal();

                    eternalGoal.SetName();
                    eternalGoal.SetDescription();
                    eternalGoal.SetPoints();
                    List<string> eternalGoal1 = eternalGoal.CreateGoal(eternalGoal.GetName(), eternalGoal.GetDescription(), eternalGoal.GetPoints());
                    goalManager.AddGoal(eternalGoal1);
                }

                else if (userGoalType == "3")
                {
                    Console.Clear();
                    ChecklistGoal checklistGoal = new ChecklistGoal();

                    checklistGoal.SetName();
                    checklistGoal.SetDescription();
                    checklistGoal.SetPoints();
                    checklistGoal.SetTarget();
                    checklistGoal.SetBonus();
                    checklistGoal.GetAmountCompleted();
                    List<string> checklistGoal1 = checklistGoal.CreateGoal(checklistGoal.GetName(), checklistGoal.GetDescription(), checklistGoal.GetPoints(), checklistGoal.IsComplete(checklistGoal.GetAmountCompleted(), checklistGoal.GetTarget()), checklistGoal.GetBonus(), checklistGoal.GetAmountCompleted());
                    goalManager.AddGoal(checklistGoal1);

                }
            }

            else if (userEntry == "2")
            {
                goalManager.DisplayGoals();

            }

            else if (userEntry == "3")
            {
                Console.Clear();
                string moveOn = "?";
                while (moveOn != "")
                {
                    goalManager.DisplayGoals();
                    Console.WriteLine("\n");
                    Console.Write("Press 'Enter' to go back to the main menu: ");
                    string moveOnEntry = Console.ReadLine();
                    moveOn = moveOnEntry;
                }
            }

            else if (userEntry == "4")
            {

            }

            else if (userEntry == "5")
            {

            }

            else if (userEntry == "6")
            {
                Console.WriteLine("Thank you!");
            }

            else
            {
                Console.WriteLine("Thank you!");
            }
        }

    }
}