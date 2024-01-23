class Program
{
    static void Main(string[] args)
    {
        Job job1 = new()
        {
            _company = "Dunkin' Donuts",
            _jobTitle = "Custodian",
            _endYear = 2013,
            _startYear = 1977
        };

        Job job2 = new()
        {
            _company = "Apple",
            _jobTitle = "CEO",
            _endYear = 2024,
            _startYear = 2013
        };

        Resume resume = new();
        resume._name = "Henry Johnson";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Diplay();
    }
}