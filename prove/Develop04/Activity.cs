class Activity {
    private string name;
    private string description;
    protected int duration;


    protected Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Welcome()
    {
        Console.Clear();
        Console.Write($"Welcome to the {name}\n\n{description}\n\nHow long should the activity last? > ");
        duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready ... ");
        Spinner();
    }

    public void Ending()
    {
        Console.Clear();
        Console.Write("Well done! ");
        Spinner();
        Console.Write($"\nYou have completed {duration} seconds of {name} ");
        Spinner();
    }

    protected void Spinner()
    {
        var str = "|/-\\";
        for (int j = 0;j < 5;j++)
            foreach (char i in str) {
                Console.Write(i);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
    }

    protected void Countdown(int n)
    {
        for (int i = 0;i < n;i++) {
            Console.Write(n-i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}