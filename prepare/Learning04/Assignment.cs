using System.Xml.XPath;

class Assignment
{

    private string _studentName;

    private string _topic;

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }



    public string GetSummary()
    {
        string result = $"John Doe - Quantum Physics";
        return result;
    }

    public string GetSummary(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;

        string result = $"{_studentName} - {_topic}";
        return result;
    }

}