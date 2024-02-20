using System.Runtime.InteropServices;

class Exercise
{
    private string _date;
    private int _duration;
//-----------------------------------------------------
    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
//-----------------------------------------------------
    public virtual string GetSummary()
    {
        return "";
    }
}