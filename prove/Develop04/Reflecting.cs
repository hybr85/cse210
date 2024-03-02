class Reflecting : Activity {
    public Reflecting() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {random = new();}
    private string[] prompts = "Think of a time when you stood up for someone else.\nThink of a time when you did something really difficult.\nThink of a time when you helped someone in need.\nThink of a time when you did something truly selfless.".Split('\n');
    private string[] questions = "Why was this experience meaningful to you?\nHave you ever done anything like this before?\nHow did you get started?\nHow did you feel when it was complete?\nWhat made this time different than other times when you were not as successful?\nWhat is your favorite thing about this experience?\nWhat could you learn from this experience that applies to other situations?\nWhat did you learn about yourself through this experience?\nHow can you keep this experience in mind in the future?".Split('\n');
    private Random random;


    public void Reflect() {
        string prompt = prompts[random.Next(prompts.Length)];
        Console.Clear();
        Console.Write("Consider the following prompt:\n\n");
        Console.Write($"---- {prompt} ----\n\n");
        Console.Write("Enter when you have something > ");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        Console.Write("\n\nGet ready to ponder ... ");
        Countdown(5);
        Console.Clear();
        Console.Write($"---- {prompt} ----\n\n");

        for (int i = 0;i < Math.Ceiling((float)duration/15);i++) {
            Console.Write($"> {questions[random.Next(questions.Length)]} ");
            Spinner();
            Spinner();
            Spinner();
            Console.Write("\n");
        }
    }
}