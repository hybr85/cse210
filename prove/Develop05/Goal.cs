class Goal {
    private string title;
    private string description;
    protected int points;
    private bool isComplete;

    public Goal(string title, string description, int points)
    {
        this.title = title;
        this.description = description;
        this.points = points;
    }

    public Goal(string loadstring)
    {
        string[] parts = loadstring.Split("||");
        title = parts[0];
        description = parts[1];
        points = int.Parse(parts[2]);
        isComplete = bool.Parse(parts[3]);
    }

    public virtual string Display()
    {
        return $"[{(isComplete?'X':' ')}] {title} - {description}";
    }

    public string DisplayShort()
    {
        return title;
    }

    public virtual int RecordEvent()
    {
        if (!isComplete) {
            isComplete = true;
            return points;
        }
        return 0;
    }

    public virtual string Export()
    {
        return $":{title}||{description}||{points}||{isComplete}";
    }
}