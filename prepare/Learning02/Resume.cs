using System.ComponentModel.DataAnnotations;

//create new class called Resume
public class Resume
{
    //creates new string memeber of Resume class
    public string _name;

    //creates new List member of Resume class
    public List<Job> _jobs = new List<Job>();


    //creates new method for Resume class
    public void DisplayJobs()
    {
        //displays _name member
        Console.WriteLine(_name);
        //displays string
        Console.WriteLine("Jobs:");
        //loop interating through the _jobs list
        foreach (Job j in _jobs)
            {
                //creates a string derived from the Jobs class behavior DisplayInfo
                string summary = j.DisplayInfo();
                //output
                Console.WriteLine(summary);
            }
    }
}