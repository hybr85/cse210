public class Entry
{
    string prompt;
    string response;
    string date;
    static string[] promptChoices = "Who was the most interesting person I interacted with today?\nWhat was the best part of my day?\nHow did I see the hand of the Lord in my life today?\nWhat was the strongest emotion I felt today?\nIf I had one thing I could do over today, what would it be?".Split("\n");
    static Random generator = new();


    public static string RandomPrompt(){
        return promptChoices[generator.Next(0,promptChoices.Length)];
    }
    public Entry(string line)
    {
        string[] split = line.Split("~|");
        prompt = split[0];
        response = split[1];
        date = split[2];
    }

    public Entry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        date = DateTime.Now.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"{date}: {prompt}\n{response}\n");
    }

    public string Export()
    {
        return $"{prompt}~|{response}~|{date}";
    }
}