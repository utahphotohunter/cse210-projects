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
    public override void SetMiles(float distanceInFeet, double miles, int laps)
    {
        double mile = Math.Round(laps * 50 / 1000 * 0.62, 1);
        
        _miles = mile;
    }


    public double GetSpeed(int durationInMinutes, double miles)
    {
        float hours = durationInMinutes / 60;
        double speed = Math.Round(miles / hours, 1);
        return speed;
    }

    public override void SetExerciseType(string exerciseType = "swimming")
    {
        _exerciseType = exerciseType;
    }
}