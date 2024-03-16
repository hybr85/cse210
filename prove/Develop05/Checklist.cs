class Checklist : Goal {
    private int count;
    private int pointsEach;
    private int timesCompleted;

    public Checklist(string title, string description, int points, int count, int bonus) : base(title, description, bonus) {
        this.count = count;
        this.pointsEach = points;
        this.timesCompleted = 0;
    }

    public Checklist(string loadstring) : base(loadstring.Split("~~")[0]) {
        string[] parts = loadstring.Split("~~")[1].Split("||");
        this.count = int.Parse(parts[0]);
        this.pointsEach = int.Parse(parts[1]);
        this.timesCompleted = int.Parse(parts[2]);
    }

    public override string Display()
    {
        return $"{base.Display()} ({timesCompleted}/{count})";
    }

    public override string Export()
    {
        return $"Checklist{base.Export()}~~{count}||{pointsEach}||{timesCompleted}";
    }

    public override int RecordEvent()
    {
        if (timesCompleted < count - 1) {
            timesCompleted++;
            return pointsEach;
        }
        else if (timesCompleted == count - 1) {
            timesCompleted++;
            return pointsEach + base.RecordEvent();
        }
        else return 0;
    }
}