using System.Dynamic;

public class Reference
//creats Reference class
{
    private string _book;
    //creates new member variable _book

    private int _chapter;
    //creates new member variable _chapter

    private int _verse;
    //creates new member variable _verse

    private int _endVerse;
    //creates new member variable _endVerse

    public Reference()
    //default constructor for Reference class. This can be changed later by the user if the user opts to
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
    }

    public string GetReference()
    //returns a string that organizes the different default member elements into coherant info
    {
        string result = $"{_book} {_chapter}:{_verse}";
        //variable to store the orgainized string of default values
        return result;
        //returns default string
    }
    public string GetReference(string _book, int _chapter, int _verse)
    //returns a string that organizes the different custom member elements into coherant info with 1 verse given
    {
        string result = $"{_book} {_chapter}:{_verse}";
        //variable to store the orgainized string of custom values
        return result;
        //returns custom string
    }

    public string GetReference(string _book, int _chapter, int _verse, int _endVerse)
    //returns a string that organizes the different custom member elements into coherant info with 2 verse given
    {
        string result = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        //variable to store the orgainized string of custom values
        return result;
        //returns custom string
    }

    public string SetBook()
    //method to set the value of _book
    {
        Console.Write("Please enter the name of the book: ");
        //prompts the user to enter a value for _book
        string newBook = Console.ReadLine();
        //variable to store the users given value
        return newBook;
        //returns the users given value
    }

    public int SetChapter()
    //method to set the value of _chapter
    {
        Console.Write("Please enter the chapter number: ");
        //prompts the user to enter a value for _chapter
        string newChapter = Console.ReadLine();
        //variable to store the users given value
        int newChapterNum = int.Parse(newChapter);
        //converts user response from Reference type to int type
        return newChapterNum;
        //returns the converted users given value
    }

    public int SetVerse1()
    //method to set the value of _verse
    {
        Console.Write("Please enter the verse number: ");
        //prompts the user to enter a value for _verse
        string newVerse = Console.ReadLine();
        //variable to store the users given value
        int newVerseNum = int.Parse(newVerse);
        //converts user response from Reference type to int type
        return newVerseNum;
        //returns the converted users given value
    }

    public int SetVerse2()
    //method to set the value of _endVerse
    {
        Console.Write("Please enter the ending verse number: ");
        //prompts the user to enter a value for _endVerse
        string newVerse2 = Console.ReadLine();
        //variable to store the users given value
        int newVerse2Num = int.Parse(newVerse2);
        //converts user response from Reference type to int type
        return newVerse2Num;
        //returns the converted users given value
    }
}