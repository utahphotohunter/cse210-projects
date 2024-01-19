using System;
using System.Diagnostics.Metrics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");


        PromptGenerator _promptList = new PromptGenerator();
        //creats new instance of the PromptGenerator class
        _promptList._prompts.Add(_promptList._prompt1);
        //adds the first prompt from the Entry class to a list stored in the PromptGenerator class
        _promptList._prompts.Add(_promptList._prompt2);
        //adds the second prompt from the Entry class to a list stored in the PromptGenerator class
        _promptList._prompts.Add(_promptList._prompt3);
        //adds the third prompt from the Entry class to a list stored in the PromptGenerator class
        _promptList._prompts.Add(_promptList._prompt4);
        //adds the fourth prompt from the Entry class to a list stored in the PromptGenerator class
        _promptList._prompts.Add(_promptList._prompt5);
        //adds the fifth prompt from the Entry class to a list stored in the PromptGenerator class
        int number = _promptList.GetRandomPrompt();
        //generates a random number for later use
        Console.WriteLine(_promptList._prompts[number]);
        //uses the above random number as an index to get a random prompt from the PromptGenerator class


        

       

        
        string menuResponse = "";
        

        while (menuResponse != "5")
        {
            Console.WriteLine("Please pick an option 1-5");
            //Below is the menu for the user to interact with
            
            Console.WriteLine("1. Write a Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What action would you like to take? ");
            menuResponse = Console.ReadLine();
            //stores users menu response to be used in a loop

            while (menuResponse != "1" && menuResponse != "2" && menuResponse != "3" && menuResponse != "4" && menuResponse != "5")
            {
           Console.WriteLine("Please pick an option 1-5");
           Console.Write("What action would you like to take? ");
           menuResponse = Console.ReadLine();
            }

            if (menuResponse == "1")
            {
                Console.WriteLine("Awesome Job!");
            }

            else if (menuResponse == "2")
            {
                //code to display all journal entries from Journal class list
            }

            else if (menuResponse == "3")
            {
                //code to save journal to a file and have user provide a file name
            }

            else if (menuResponse == "4")
            {
                //code to load a journal from a file that the user gives the name for
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Thank you for journaling today!\n");











        DateTime currentDate = DateTime.Now;
        //gets current date and time
        string currentDateText = currentDate.ToShortDateString();
        //converts currentDate from DateTime element to string element


        Entry userEntry = new Entry();
        //creates new instance of Entry class
        string userText = Console.ReadLine();
        //creates variable to store the response from the user
        userEntry._entryText = userText;
        //stores the response from the user in the Entry class for later use
        userEntry._promptText = _promptList._prompts[number];
        //stores the prompt the user responded to in the Entry class for later use
        userEntry._date = currentDateText;
        //stores the date and time associated with the users response in the Entry class for later use

        Journal currentJournal = new Journal();
        //creates new instance of the Journal class
        currentJournal._entries.Add(userEntry);
        //takes the current userEntry element from the Entry class and stores it in a list in the Journal class

        userEntry.Display();
        //displays the current entry stored the in the Entry class

        currentJournal.DisplayAll();
        //displays all the entries stored in the Journal class


    }
}