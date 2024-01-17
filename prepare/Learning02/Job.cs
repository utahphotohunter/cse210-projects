//creates Job class
public class Job
{
    //create memeber _company
    public string _company;
    //create member _jobTitle
    public string _jobTitle;
    //create member _startYear
    public int _startYear;
    //create member _endYear
    public int _endYear;
    //defines behavior for Job class
    public string DisplayInfo()
    {
        //creates string summary
        string summary = ($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        //returns summary string
        return summary;
    }
}