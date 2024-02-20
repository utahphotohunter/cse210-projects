using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Exercise
{
    private string _date;
    private float _durationInMinutes;
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

    public float GetDuration()
    {
        return _durationInMinutes;
    }
//-----------------------------------------------------
    public double GetPace(float durationInMintutes, double miles)
    {
        double pace = Math.Round(durationInMintutes / miles, 1);

        return pace;
    }

    public virtual string GetSummary(string date, float durationInMintutes, double miles, double speed, double pace, string type)
    {
        return "";
    }
}