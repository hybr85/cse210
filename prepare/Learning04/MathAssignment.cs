class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        this.textbookSection = textbookSection;
        this.problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {textbookSection} Problems {problems}";
    }
}