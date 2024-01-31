public class Menu
{
    readonly string options = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";

    public int Ask()
    {
        Console.Clear();
        Console.Write($"{options}\nEnter choice > ");
        return int.Parse(Console.ReadLine());
    }
}