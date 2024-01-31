public class Journal
{
    List<Entry> entries = new();


    public void Add(Entry entry)
    {
        entries.Add(entry);
    }

    public int NumEntries()
    {
        return entries.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Entries: {entries.Count}\n");
        foreach (Entry entry in entries) entry.Display();
    }

    public void Save(string path)
    {
        using StreamWriter file = new(path);
        foreach (Entry entry in entries) file.WriteLine(entry.Export());
    }

    public void Load(string path)
    {
        foreach (string line in File.ReadAllLines(path)) entries.Add(new Entry(line));
    }
}