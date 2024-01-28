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
}