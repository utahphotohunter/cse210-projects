using System.Diagnostics.Contracts;

class WritingAssignment : Assignment
{
    private string _title;


    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }



    public string GetWritingInformation()
    {
        string result = $"{GetStudentName()} - {GetTopic()}\n{_title} by {GetStudentName()}";
        return result;
    }

    public string GetWritingInformation(string title)
    {
        string result = $"{GetStudentName()} - {GetTopic()}\n{title} by {GetStudentName()}";
        return result;
    }



}