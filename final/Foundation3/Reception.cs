class Reception : Event
{
    private string _rsvp;
//-------------------------------------------------------------
    public void SetRsvp(string rsvp)
    {
        _rsvp = rsvp;
    }
    
    public string GetRsvp()
    {
        return _rsvp;
    }
//-------------------------------------------------------------
    public override string GetStandardDetails(string title, string description, string date, string time, string address)
    {
        return $"Join us for {title}! {description} on {date} at {time}. The event will be at {address}";
    }

    public override string GetFullDetails(string title, string description, string date, string time, string address, string type = "Reception", string limit = "(insert limit)", string speaker = "(insert speaker)", string rsvp = "thisreception@yahoo.com", string weather = "na")
    {
        return $"{type} - RSVP at {rsvp} - Join us for {title}! {description} on {date} at {time}. The event will be at {address}.";
    }

    public override string GetShortDescription(string title, string date, string type = "Reception")
    {
        return $"{type} - {title} - {date}";
    }
}