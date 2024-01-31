public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;
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
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
    public void Display()
    {
        System.Console.WriteLine($"{_date}: {_prompt}\n{_response}\n");
    }
    public string Export()
    {
        return $"{_prompt}~|{_response}~|{_date}";
    }
}