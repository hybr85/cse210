class Breathing : Activity {
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}


    public void Breathe() {
        Console.Clear();
        for (int i = 0;i < Math.Ceiling(((float)duration)/10);i++) {
            Console.Write("Breath in ... ");
            Countdown(4);
            Console.Write("\nBreath out ... ");
            Countdown(6);
            Console.Write("\n\n");
        }
    }
}