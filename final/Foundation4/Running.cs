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
    public override void SetSpeed(int durationInMinutes, double miles)
    {
        float hours = durationInMinutes / 60;
        double speed = Math.Round(miles / hours, 2);

        _speed = speed;
    }

    public override void SetMiles(float distanceInFeet, double miles, int laps)
    {
        double mile = Math.Round(distanceInFeet / 5280, 1);
        
        _miles = mile;
    }


    public override void SetExerciseType(string exerciseType = "running")
    {
        _exerciseType = exerciseType;
    }
}