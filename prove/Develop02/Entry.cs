using System.Xml.XPath;

public class Entry
//creates new class Entry

{
    
    public string _entryText;
    //creates new member _entryText to store the users entry
    
    public string _date;
    //creates new member _date to store the date the user creates an entry
    
    public string _promptText;
    //creates new member _promptText to store the randomly generated prompt from a list of prompts taken from the PromptGenerator class

    
    public void Display()
    //a method for the Entry class to display the date and entry given by user
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date}\n{_promptText}\n{_entryText}\n");
    }

    public string ReturnJournalEntry()
    //a method for the Entry class to return the date and entry given by user
    {
        string result = $"{_date}\n{_promptText}\n{_entryText}";
        return result;
    }    
}