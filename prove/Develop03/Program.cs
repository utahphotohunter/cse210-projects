using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Reference practiceRef = new Reference();
        //creates new instance of Reference class

        Word practiceWord = new Word();
        //creates new instance of Word class


        Console.WriteLine("Welcome to the scripture memorizer. Press 'Enter' to continue.");
        //gives instructions to user
        
        string keyStroke = "";
        //sets initial value of keyStroke variable to the enter key
        string userKeyStroke = Console.ReadLine();
        //user sets value for userKeyStroke variable
        

        while (userKeyStroke != keyStroke)
        //checks if user hit enter key
        {
            Console.Clear();
            //clears console
            Console.WriteLine("Please press 'Enter' to continue.");
            //prompts user to try again pressing the enter key
            userKeyStroke = Console.ReadLine();
            //user sets value for userKeyStroke variable
        }

        Console.Clear();
        //clears console

        Console.Write("Would you like to enter your own scripture or be provided one?\n\nUse your own scripture: U\nBe provided one: P\n\nAnswer: ");
        //prompts user to select option

        string useOrProvide = Console.ReadLine();
        //user selects option

        while (useOrProvide != "U" && useOrProvide != "P")
        //checks if user selected available option
        {
            Console.Clear();
            //clears console
            Console.WriteLine("You have not entered a valid option. Please Try again.\n");
            //informs user of invalid selection
            Console.Write("Would you like to enter your own scripture or be provided one?\n\nUse your own scripture: U\nBe provided one: P\n\nAnswer: ");
            //prompts user to make a valid selection
            useOrProvide = Console.ReadLine();
            //user makes selection
        }

        if (useOrProvide == "P")
        //checks if user opted to use a provided element
        {
            Reference providedRef = new Reference();
            //creates new instance of default Reference class
            string basicRef = providedRef.GetReference();
            //assigns string variable to store the return string from GetReference function
            Console.WriteLine(basicRef);
            //displays the returned string

            Word providedWord = new Word();
            //creates new instance of default Word class
            var scriptureList = providedWord.GetList();
            //assignes variable to store the return from the GetList function
            providedWord.HideWords();
            //displays the returned material

            
            
        }

        else if (useOrProvide == "U")
        //checks if user opted to write their own content
        {
            string book = practiceRef.SetBook();
            //allows user to set the _book member variable

            int chapter = practiceRef.SetChapter();
            //allows the user to set the _chapter member variable

            int startVerse = practiceRef.SetVerse1();
            //allows the user to set the _verse member variable

            string newReference = practiceRef.GetReference(book, chapter, startVerse);
            //calls the GetReference function to store the full reference which contains only one verse

            Console.WriteLine(newReference);
            //displays the stored return from the GetReference function
        }
    }
}