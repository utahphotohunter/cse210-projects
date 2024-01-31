using System.Xml.XPath;

class MathAssignment : Assignment
{

    private string _textbookSection;

    private string _problems;

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetTextbookSection(string section)
    {
        _textbookSection = section;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }


    public string GetHomeworList()

        {
            string result = "John Doe - Quantum Physics\nSection 9.3 Problems 7-20";
            return result;
        }

    public string GetHomeworkList(string section, string problems)
    {
        _problems = problems;
        _textbookSection = section;
        string result = $"{GetStudentName()} - {GetTopic()}\nSection {section} Problems {problems}";
        return result;
    }

}