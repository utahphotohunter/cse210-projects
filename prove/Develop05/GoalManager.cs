class GoalManager
{
    private List<List<string>> _goals;
    private int _points;
//------------------------------------------------------------------------------------
    public void AddGoal(List<string> entry)
    {
        _goals.Add(entry);
    }
//------------------------------------------------------------------------------------
    public void DisplayGoals()
    {
        int goalNumber = 0;
        foreach (List<string> i in _goals)
        {
            goalNumber = goalNumber + 1;
            string name = i[0];
            string description = i[1];
            string points = i[2];
            string completed = i[3];
            string amountCompleted = i[4];
            string target = i[5];
            string bonus = i[6];
            string goalType = i[7];
            
            if (goalType == "SimpleGoal")
            {
                Console.WriteLine($"{goalNumber}. [{completed}], {name}, {points} points");
            }

            else if (goalType == "EternalGoal")
            {
                Console.WriteLine($"{goalNumber}. [ ], {name}, {points} points");
            }

            else if (goalType == "ChecklistGoal")
            {
                Console.WriteLine($"{goalNumber}. [{completed}], {name}, {points} points -- {amountCompleted}/{target} complete");
            }
        }
    }
//------------------------------------------------------------------------------------
    public void DisplayPlayerInfo()
    {
       int goalsMade = _goals.Count();
       int pointsReceived = _points;

       Console.WriteLine($"Goals Made: {goalsMade}");
       Console.WriteLine($"Total Points: {pointsReceived}");
    }
//------------------------------------------------------------------------------------
    public void SaveGoals()
    {

    }
//------------------------------------------------------------------------------------
    public void LoadGoals()
    {

    }
}

