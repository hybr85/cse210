class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        bool run = true;
        string prompt;
        string response;

        while(run)
        {
            switch (Menu.Ask())
            {
                case 1: // write
                    prompt = Entry.RandomPrompt();
                    Console.Write($"{prompt}\n> ");
                    response = Console.ReadLine();
                    if (response != "") journal.Add(new Entry(prompt, response));
                    break;

                case 2: // display
                    journal.Display();
                    Console.Write("Press enter to continue > ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter){}
                    break;

                case 3: // load
                    Console.Write("Enter file name > ");
                    journal.Load(Console.ReadLine());
                    break;

                case 4: // save
                    Console.Write("Enter file name > ");
                    journal.Save(Console.ReadLine());
                    break;

                case 5: // quit
                    run = false;
                    break;

                default:
                    break;
            }
        }
    }
}