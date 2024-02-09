using System.ComponentModel;
using System.Dynamic;
using System.Runtime;
using System.Xml.XPath;

class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

//------------------------------------------------------------------------------------
    public void SetName()
    {
        Console.Write("What is the name of this goal? ");
        string shortName = Console.ReadLine();

        _shortName = shortName;
    }
//------------------------------------------------------------------------------------
    public string GetName()
    {
        return _shortName;
    }
//------------------------------------------------------------------------------------
    public void SetPoints()
    {
        Console.Write("How many points will this goal be worth? ");
        string points = Console.ReadLine();

        _points = points;
    }
//------------------------------------------------------------------------------------
    public string GetPoints()
    {
        return _points;
    }
//------------------------------------------------------------------------------------
    public void SetDescription()
    {
        Console.Write("Provide a description of this goal: ");
        string description = Console.ReadLine();

        _description = description;
    }
//------------------------------------------------------------------------------------
    public string GetDescription()
    {
        return _description;
    }
//------------------------------------------------------------------------------------
    public virtual int RecordEvent(int target = 1, int completed = 0)
    {
        Console.Write("Event: ");
        string recordedEvent = Console.ReadLine();

        if (recordedEvent != "")
        {
            return 1;
        }

        else
        {
            return 2;
        }
    }
//------------------------------------------------------------------------------------
    public virtual string IsComplete(int amountCompleted, int target = 1)
    {
        if (amountCompleted == target)
        {
            return "X";
        }

        else
        {
            return " ";
        }
    }
//------------------------------------------------------------------------------------
    public virtual List<string> CreateGoal(string shortName, string description, string points, string isCompleted, int target, int bonus, string goalType, int amountCompleted = 0)
    {
        string tartgetString = target.ToString();
        string bonusString = bonus.ToString();
        string amountCompletedString = amountCompleted.ToString();
        List<string> result = new List<string> {shortName, description, points, isCompleted, amountCompletedString, tartgetString, bonusString, goalType};
        return result;
    }
//------------------------------------------------------------------------------------
    public virtual void DisplayGoal(List<string> list)
    {
        foreach (string i in list)
        {
            Console.Write($"{i} ");
        }
    }

}