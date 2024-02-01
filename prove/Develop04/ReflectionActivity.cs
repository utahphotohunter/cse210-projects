using System.Dynamic;

class ReflectionActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public void SetCount(int count)
    {
        _count = count;
    }

    public int GetCount()
    {
        return _count;
    }

    public void AddToPrompts(string entry)
    {
        _prompts.Add(entry);
    }

    public List<string> GetList()
    {
        return _prompts;
    }

    public int GetListLength()
    {
        int result = _prompts.Count();
        return result;
    }



}