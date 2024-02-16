class Video
{
    private string _title;
    private string _author;
    private int _length;

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



}