class Biking : Exercise
{
    private float _miles;
    private double _speed;
//-----------------------------------------------------
    public void SetMiles(float miles)
    {
        _miles = miles;
    }

    public float GetMiles()
    {
        return _miles;
    }

    public void SetSpeed(float durationInMinutes, float miles)
    {
        float hours = durationInMinutes / 60;
        double speed = Math.Round(hours / miles, 1);
        _speed = speed;
    }

    private double GetSpeed()
    {
        return _speed;
    }
//-----------------------------------------------------
    public override string GetSummary(string date, float durationInMinutes, double miles, double speed, double pace, string type = "Biking")
    {
        string summary = $"{date} {type} ({durationInMinutes} min): Distance {miles} miles, Speed {speed}, Pace: {pace} min per mile";
        return summary;
    }
}
