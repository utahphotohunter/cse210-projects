class Lecture : Event
{
    private string _limit;
    private string _speaker;
//-------------------------------------------------------------
    public void SetLimit(string limit)
    {
        _limit = limit;
    }

    public string GetLimit()
    {
        return _limit;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
//-------------------------------------------------------------
    public override string GetStandardDetails(string title, string description, string date, string time, string address)
    {
        return $"Join us for {title}! {description} on {date} at {time}. The event will be at {address}";
    }

    public override string GetFullDetails(string title, string description, string date, string time, string address, string type = "Lecture", string limit = "(insert limit)", string speaker = "(insert speaker)", string rsvp = "no", string weather = "na")
    {
        return $"{type} - Capacity: {limit} - Join us for {title}! {description} on {date} at {time}. The event will be at {address}.";
    }

    public override string GetShortDescription(string title, string date, string type = "Lecture")
    {
        return $"{type} - {title} - {date}";
    }
}