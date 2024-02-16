class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<List<string>> _comments = new List<List<string>> {};

// ----------------------------------------------
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public void AddComments(List<string> comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (List<string> comment in _comments)
        {
            string author = comment[0];
            string text = comment[1];
            string result = $"{author}: \n'{text}'";
            Console.WriteLine(result);
        }
    }

    public void VideoSummary()
    {
        int commentCount = _comments.Count();
        Console.WriteLine("--------------------------------");
        Console.WriteLine(_title);
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Created by: {_author}");
        Console.WriteLine($"{_length} seconds");
        Console.WriteLine($"{commentCount} comments\n");
        foreach (List<string> comment in _comments)
        {
            string author = comment[0];
            string text = comment[1];
            string result = $"{author}: \n    '{text}'";
            Console.WriteLine(result);
        }
        Console.WriteLine("\n");
    }
}