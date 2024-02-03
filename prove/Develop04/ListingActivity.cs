class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string> {"Who in your life makes you a better person?", "What in your home makes your life easier than it would be without it?", "What makes you smile?", "Who could use your help?"};

    private List<string> _userResponses = new List<string> {};


    public void SetCount(int count)
    {
        _count = count;
    }

    public int GetCount()
    {
        return _count;
    }

    public void AddToPromptList(string userInput)
    {
        _prompts.Add(userInput);
    }

    public void AddToResponseList(string userInput)
    {
        _userResponses.Add(userInput);
    }


    public List<string> GetPromptsList()
    {
        return _prompts;
    }
    
    public List<string> GetResponseList()
    {
        return _userResponses;
    }

    public int GetListCount(List<string> list)
    {
        int result = list.Count();
        return result;
    }

    public void ClearList(List<string> list)
    {
        list.Clear();
    }




    public void ListingExercise(int seconds, List<string> promptList, List<string> responseList)
    {
        ClearList(responseList);
        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine("Ready?");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Begin");
        Thread.Sleep(1000);
        Console.Clear();

        Random rnd = new Random();
        int i = rnd.Next(4);
        Console.WriteLine(promptList[i]);
        Thread.Sleep(3000);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("Response: ");
            string userEntry = Console.ReadLine();
            AddToResponseList(userEntry); 
        }

        Console.Clear();
        Console.WriteLine($"Good job jotting down things! You were able to list {GetListCount(responseList)} things in resopnse to the provided prompt!");

        Thread.Sleep(4000);
        Console.Clear();
    }


}