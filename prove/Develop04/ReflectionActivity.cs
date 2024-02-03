using System.Dynamic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {"Think of a time you saw the Lord's hand in your life this week.", "Consider what has been one good thing about your day today.", "Think of an act of kindness you witnessed this month.", "Think of a time you felt happy.", "Think of a small miracle have you seen today."};
    private List<string> _questions = new List<string> {"How frequently does this happen?", "Do you think this happens more often than you notice?", "Is this something anyone can experience in daily life?", "Could you make this happen more frequently?", "How could you use this to make someone's day better?"};

    private List<string> _spinnerChars = new List<string> {"\\", "|", "/", "-", "\\", "|", "/", "-"};

    private int _delayTime = 500;

    public void AddToList(List<string> list, string entry)
    {
        list.Add(entry);
    }

    public string GetRandomIndex(List<string> list)
    {
        Random rnd = new Random();
        int i = rnd.Next(5);
        return list[i];
    }

    public int GetListLength(List<string> list)
    {
        int result = list.Count();
        return result;
    }

    public List<string> GetPromptList()
    {
        return _prompts;
    }

    public List<string> GetQuestionList()
    {
        return _questions;
    }

    public void Spinner()
    {
        Console.Write(_spinnerChars[0]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[1]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[2]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[3]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[4]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[5]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[6]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(_spinnerChars[7]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }


    public void ReflectionExercise(int seconds, List<string> promptList, List<string> questionList)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine(GetRandomIndex(promptList));
            Thread.Sleep(_delayTime);
            Console.WriteLine("");
            Console.Write(GetRandomIndex(questionList));
            Spinner();
            Thread.Sleep(_delayTime);
            Console.WriteLine("");
            Console.Write(GetRandomIndex(questionList));
            Spinner();
            Thread.Sleep(_delayTime);
            Console.WriteLine("");
            Console.Write(GetRandomIndex(questionList));
            Spinner();
            Thread.Sleep(_delayTime);
        }
    }

}