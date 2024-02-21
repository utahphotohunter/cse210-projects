class Biking : Exercise
{
//-----------------------------------------------------
    public override void SetMiles(float distanceInFeet, double miles, int laps)
    {
        _miles = miles;
    }

    public override void SetSpeed(int durationInMinutes, double miles)
    {
        float hours = durationInMinutes / 60;
        double speed = Math.Round(miles / hours, 1);
        
        _speed = speed;
    }
//-----------------------------------------------------
    public override void SetExerciseType(string exerciseType = "biking")
    {
        _exerciseType = exerciseType;
    }
}
