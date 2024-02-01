class Activity
{
    private string _name;

    private string _description;

    private string _openMessage;

    private string _endMessage;

    private int _duration;


    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void DisplayOpenMessage(string name)
    {
        Console.WriteLine($"Welcome to the {name}.");
    }

    public void SetOpenMessage(string openMessage)
    {
        _openMessage = openMessage;
    }

    public string GetOpenMessage()
    {
        return _openMessage;
    }



    public void DisplayEndMessage(string name, int seconds)
    {
        Console.WriteLine($"Well done. You just spent {seconds} seconds in the the {name}.");
    }

    public void SetEndMessage(string endmessage)
    {
        _endMessage = endmessage;
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }





}