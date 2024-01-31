public class Journal
{
    List<Entry> _entries = new();


    public void Add(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine($"Entries: {_entries.Count}\n");
        foreach (Entry entry in _entries) entry.Display();
    }

    public void Save(string path)
    {
        using StreamWriter file = new(path);
        foreach (Entry entry in _entries) file.WriteLine(entry.Export());
    }

    public void Load(string path)
    {
        foreach (string line in File.ReadAllLines(path)) _entries.Add(new Entry(line));
    }
}