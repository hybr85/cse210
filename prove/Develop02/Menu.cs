public class Menu
{
    readonly string _options = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";
    readonly string[] _prompts = "Who was the most interesting person I interacted with today?\nWhat was the best part of my day?\nHow did I see the hand of the Lord in my life today?\nWhat was the strongest emotion I felt today?\nIf I had one thing I could do over today, what would it be?".Split("\n");
    Random generator = new();


    public int Ask()
    {
        Console.Clear();
        Console.Write($"{_options}\nEnter choice > ");
        return int.Parse(Console.ReadLine());
    }

    public string RandomPrompt()
    {
        return _prompts[generator.Next(0,_prompts.Length)];
    }
}