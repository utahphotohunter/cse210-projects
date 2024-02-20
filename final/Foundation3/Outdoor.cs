class Outdoor : Event
{
    private string _weather;
//-------------------------------------------------------------
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
//-------------------------------------------------------------
    public override string GetStandardDetails(string title, string description, string date, string time, string address)
    {
        return $"Join us for {title}! {description} on {date} at {time}. The event will be at {address}";
    }

    public override string GetFullDetails(string title, string description, string date, string time, string address, string type = "Outdoor Event", string limit = "na", string speaker = "na", string rsvp = "no", string weather = "(insert weather)")
    {
        return $"{type} - Expected Weather: {weather} - Join us for {title}! {description} on {date} at {time}. The event will be at {address}.";
    }

    public override string GetShortDescription(string title, string date, string type = "Outdoor Event")
    {
        return $"{type} - {title} - {date}";
    }
}