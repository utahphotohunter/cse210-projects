using System.Transactions;

class Comment
{
    private List<string> _comment = new List<string> {};
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

    public List<string> GetComment()
    {
        return _comment;
    }
}