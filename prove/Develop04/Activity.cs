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

    public void SetOpenMessage(string openMessage)
    {
        _openMessage = openMessage;
    }

    public void DisplayOpenMessage()
    {
        Console.WriteLine(_openMessage);
    }

    public void SetEndMessage(string endMessage)
    {
        _endMessage = endMessage;
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