public class Resume
{
    public string _name;
    public List<Job> _jobs = new();

    public void Diplay()
    {
        System.Console.WriteLine($"Name: {_name}\nJobs:");
        foreach(Job job in _jobs) job.Display();
    }
}