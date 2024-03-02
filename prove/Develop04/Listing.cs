class Listing : Activity {
    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){random = new();}
    private string[] prompts = "Who are people that you appreciate?\nWhat are personal strengths of yours?\nWho are people that you have helped this week?\nWhen have you felt the Holy Ghost this month?\nWho are some of your personal heroes?".Split('\n');
    private Random random;


    public void List() {
        Console.Clear();
        Console.Write("List as many responses as you can to the following prompt:\n\n");
        Console.Write($"---- {prompts[random.Next(prompts.Length)]} ----");
        Console.Write("\n\nYou may begin in ");
        Countdown(5);
        Console.Write("\b\b\b  \b\bnow\n");

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.Write($"You listed {count} items ");
        Spinner();
    }
}