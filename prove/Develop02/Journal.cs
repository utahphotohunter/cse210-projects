using System.Runtime.CompilerServices;

public class Journal
//creates new class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //creates list _entries that stores any new entries from class Entry

    
    public void DisplayAll()
    //method for Journal class that displays all the entries contained in the _entries list
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    
    public void SaveToFile(string file)
    //method for Journal class to store the current _entries list to a new file
    {

    }

    public void LoadFromFile(string file)
    //method for Journal class that loads an _entries list from a stored file
    {

    }
}
