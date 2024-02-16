using System.Transactions;

class Comment
{
    private List<string> _comment = new List<string> {};
    private List<List<string>> _comments = new List<List<string>> {};
    private string _author;
    private string _text;
// ----------------------------------------------
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }
// ----------------------------------------------
    public void MakeComment(string author, string text)
    {
        _comment.Add(author);
        _comment.Add(text);
    }

    public void AddComment(List<string> comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (List<string> comment in _comments)
        {
            string author = comment[0];
            string text = comment[1];
            string result = $"{author}: {text}";
            Console.WriteLine(result);
        }
    }
}