class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
//-------------------------------------------------------------
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address;
    }
}