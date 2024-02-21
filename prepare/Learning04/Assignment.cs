class Assignment
{
    private string studentName;
    private string topic;

    protected Assignment(string studentName, string topic)
    {
        this.studentName = studentName;
        this.topic = topic;
    }

    public string GetSummary()
    {
        return $"{studentName} - {topic}";
    }

    protected string GetName()
    {
        return studentName;
    }
}