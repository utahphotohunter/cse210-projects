class SimpleGoal : Goal
{
    public override List<string> CreateGoal(string shortName, string description, string points, string completed = "No", int target = 0, int bonus = 0)
    {
        string tartgetString = target.ToString();
        string bonusString = bonus.ToString();
        List<string> result = new List<string> {shortName, description, points, completed, tartgetString, bonusString};
        return result;
    }
//------------------------------------------------------------------------------------
    public override void DisplayGoal(List<string> list)
    {
        int index = -1;

        foreach (string i in list)
        {
            index = index + 1;
            if (index < 4)
            {
                Console.Write($"{i} ");
            }
        }
    }
}