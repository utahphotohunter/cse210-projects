using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Exercise
{
    private string _date;
    private int _durationInMinutes;
    protected double _speed;
    private double _pace;
    protected double _miles;
    protected string _exerciseType;
//-----------------------------------------------------
    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDuration(int durationInMinutes)
    {
        _durationInMinutes = durationInMinutes;
    }

    public int GetDuration()
    {
        return _durationInMinutes;
    }

    public virtual void SetMiles(float distanceInFeet, double miles, int laps)
    {

    }

    public double GetMiles()
    {
        return _miles;
    }

    public virtual void SetSpeed(int durationInMinutes, double miles)
    {

    }

    public double GetSpeed()
    {
        return _speed;
    }

    public void SetPace(int durationInMintutes, double miles)
    {
        double pace = Math.Round(durationInMintutes / miles, 1);

        _pace = pace;
    }

    public double GetPace()
    {
        return _pace;
    }

    public virtual void SetExerciseType(string exerciseType)
    {
        _exerciseType = exerciseType;
    }

    public string GetExerciseType()
    {
        return _exerciseType;
    }
//-----------------------------------------------------
    public virtual string GetSummary(string date, int durationInMinutes, double miles, double speed, double pace, string exerciseType)
    {
        string summary = $"{date} {exerciseType} ({durationInMinutes} min) - Distance: {miles} miles, Speed: {speed} mph, Pace: {pace} min per mile";
        return summary;
    }

    public virtual string GetType(string type)
    {
        return type;
    }
}