class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
//------------------------------------------------------------------------------------
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
//------------------------------------------------------------------------------------
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
//------------------------------------------------------------------------------------
    public void SetTarget(int target)
    {
        _target = target;
    }
//------------------------------------------------------------------------------------
    public int GetTarget()
    {
        return _target;
    }
//------------------------------------------------------------------------------------
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
//------------------------------------------------------------------------------------
    public int GetBonus()
    {
        return _bonus;
    }
//------------------------------------------------------------------------------------
    public override string IsComplete(int amountCompleted, int target)
    {
        if (amountCompleted >= target)
        {
            return "X";
        }

        else
        {
            return " ";
        }
    }
//------------------------------------------------------------------------------------
    public override int RecordEvent(int target, int amountCompleted)
    {
        Console.Write("Event: ");
        string recordedEvent = Console.ReadLine();

        if (recordedEvent != "")
        {
            return amountCompleted;
        }

        else
        {
            return amountCompleted;
        }
    }
//------------------------------------------------------------------------------------
    public override List<string> CreateGoal(string shortName, string description, string points, string isCompleted, int target, int bonus, string goalType = "ChecklistGoal", int amountCompleted = 0)
    {
        string tartgetString = target.ToString();
        string bonusString = bonus.ToString();
        string amountCompletedString = amountCompleted.ToString();
        List<string> result = new List<string> {shortName, description, points, isCompleted, amountCompletedString, tartgetString, bonusString, goalType};
        return result;
    }
    
}