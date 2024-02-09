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
    
}