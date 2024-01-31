class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        Journal journal = new();
        bool run = true;
        bool saved = true;
        string prompt;
        string response;

        while(run)
        {
            switch (menu.Ask())
            {
                case 1: // write
                    prompt = Entry.RandomPrompt();
                    Console.Write($"{prompt}\n> ");
                    response = Console.ReadLine();
                    if (response != "")
                    {
                        journal.Add(new Entry(prompt, response));
                        saved = false;
                    }
                    break;

                case 2: // display
                    journal.Display();
                    Console.Write("Press enter to continue > ");
                    Console.ReadLine();
                    break;

                case 3: // load
                    Console.Write("Enter file name > ");
                    journal.Load(Console.ReadLine());
                    break;

                case 4: // save
                    Console.Write("Enter file name > ");
                    journal.Save(Console.ReadLine());
                    saved = true;
                    break;

                case 5: // quit
                    if (!saved)
                    {
                        Console.Write("Changes not saved. Exit anyway? [Y/n] > ");
                        if (Console.ReadLine().ToLower() == "n") break;
                    }
                    run = false;
                    break;

                default:
                    break;
            }
        }
    }
}