class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;


    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        book = parts[0];
        parts = parts[1].Split(':');
        chapter = int.Parse(parts[0]);
        if (parts[1].Contains('-')) {
            parts = parts[1].Split('-');
            startVerse = int.Parse(parts[0]);
            endVerse = int.Parse(parts[1]);
        }
        else startVerse = int.Parse(parts[1]);
    }

    public string DisplayString()
    {
        return $"{book} {chapter}:{startVerse}{(endVerse==0 ? "" : "-"+endVerse.ToString())}";
    }
}