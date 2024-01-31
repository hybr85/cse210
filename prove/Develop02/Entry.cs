public class Entry
{
    string _prompt;
    string _response;
    string _date;


    public Entry(string line)
    {
        string[] split = line.Split("~|");
        _prompt = split[0];
        _response = split[1];
        _date = split[2];
    }

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}\n{_response}\n");
    }

    public string Export()
    {
        return $"{_prompt}~|{_response}~|{_date}";
    }
}