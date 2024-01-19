using System.Reflection.Metadata.Ecma335;

public class PromptGenerator
//creates new class PromptGenerator
{
    
    public List<string> _prompts = new List<string>();
    //creates new list _prompts to be used later to generate a random prompt
    

    public string _prompt1 = "What was the most surprising thing about today?";
    //creates new member for PromptGenerator class that stores the string of the first prompt.
    public string _prompt2 = "What kind thing did someone do for you today?";
    //creates new member for PromptGenerator class that stores the string of the second prompt
    public string _prompt3 = "How did you help someone today?";
    //creates new member for PromptGenerator class that stores the string of the third prompt
    public string _prompt4 = "Who did you meet today that could use your prayers?";
    //creates new member for PromptGenerator class that stores the string of the fourth prompt
    public string _prompt5 = "What trials have you overcome today?";
    //creates new member for PromptGenerator class that stores the string of the fifth prompt

    
    public int GetRandomPrompt()
    //gets a random prompt from the above list and returns the prompt as a string
    {
        Random rnd = new Random();
        int result = rnd.Next(0,4);
        return result;
    }
}