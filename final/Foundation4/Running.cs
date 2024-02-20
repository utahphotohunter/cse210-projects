using System.Xml.XPath;

class Running : Exercise
{
    private float _distanceInFeet;
//-----------------------------------------------------
    public void SetDistance(float distanceInFeet)
    {
        _distanceInFeet = distanceInFeet;
    }

    public float GetDistance()
    {
        return _distanceInFeet;
    }
//-----------------------------------------------------
    public double GetSpeed(float durationInMinutes, double miles)
    {
        float hours = durationInMinutes / 60;
        double speed = Math.Round(hours / miles, 1);

        return speed;
    }

    public double GetMiles(float distanceInFeet)
    {
        double miles = Math.Round(distanceInFeet / 5280, 1);

        return miles;
    }

    public override string GetSummary(string date, float durationInMinutes, double miles, double speed, double pace, string type = "Running")
    {
        string summary = $"{date} {type} ({durationInMinutes} min): Distance {miles} miles, Speed {speed}, Pace: {pace} min per mile";
        return summary;
    }
}