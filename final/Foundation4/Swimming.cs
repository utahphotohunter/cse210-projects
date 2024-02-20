using System.Runtime.InteropServices;

class Swimming : Exercise
{
    private int _laps;
//-----------------------------------------------------
    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }
//-----------------------------------------------------
    public double GetMiles(int laps)
    {
        double miles = Math.Round(laps * 50 / 1000 * 0.62, 1);

        return miles;
    }

    public double GetSpeed(float durationInMinutes, float miles)
    {
        float hours = durationInMinutes / 60;
        double speed = Math.Round(hours / miles, 1);
        return speed;
    }

    public override string GetSummary(string date, float durationInMinutes, double miles, double speed, double pace, string type = "Swimming")
    {
        string summary = $"{date} {type} ({durationInMinutes} min): Distance {miles} miles, Speed {speed}, Pace: {pace} min per mile";
        return summary;
    }
}