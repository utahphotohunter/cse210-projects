class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
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
    public void SetTarget()
    {
        Console.Write("How many times do you want to accomplish this goal? ");
        string target = Console.ReadLine();
        int targetInt = int.Parse(target);
        _target = targetInt;
    }
//------------------------------------------------------------------------------------
    public int GetTarget()
    {
        return _target;
    }
//------------------------------------------------------------------------------------
    public void SetBonus()
    {
        Console.Write("How much would you like the bonus to be once it has all been accomplished? ");
        string bonus = Console.ReadLine();
        int bonusInt = int.Parse(bonus);
        _bonus = bonusInt;
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
            _amountCompleted = amountCompleted + 1;
            return amountCompleted;
        }

        else
        {
            return amountCompleted;
        }
    }
//------------------------------------------------------------------------------------
    public override List<string> CreateGoal(string shortName, string description, string points, string isCompleted, int target, int bonus, int amountCompleted = 0, string goalType = "ChecklistGoal")
    {
        string tartgetString = target.ToString();
        string bonusString = bonus.ToString();
        string amountCompletedString = amountCompleted.ToString();
        List<string> result = new List<string> {shortName, description, points, isCompleted, amountCompletedString, tartgetString, bonusString, goalType};
        return result;
    }
    
}