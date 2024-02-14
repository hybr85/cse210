class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new("For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.", new("Moses 1:39"));

        while (scripture.WordsLeft() != 0) {
            Console.Clear();
            Console.WriteLine(scripture.DisplayString());
            Console.Write("\nPress enter to continue, type quit to quit > ");
            if (Console.ReadLine() == "quit") return;
            scripture.HideWords(2);
        }
        
        Console.Clear();
        Console.WriteLine(scripture.DisplayString());
        Console.Write("\nPress enter to quit > ");
        while(Console.ReadKey(true).Key != ConsoleKey.Enter) ; // <- do nothing
    }
}