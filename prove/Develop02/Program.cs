using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        Journal journal = new();
        bool run = true;
        string prompt;
        string response;

        do
        {
            switch (menu.Ask())
            {
                case 1: // write
                    prompt = menu.RandomPrompt();
                    Console.Write($"{prompt}\n> ");
                    response = Console.ReadLine();
                    journal._entries.Add(new Entry(prompt, response));
                    break;
                case 2: // display
                    journal.Display();
                    break;
                case 3: // load
                    Console.Write("Enter file path > ");
                    journal.Load(Console.ReadLine());
                    break;
                case 4: // save
                    Console.Write("Enter file path > ");
                    journal.Save(Console.ReadLine());
                    break;
                case 5: // quit
                    run = false;
                    break;
                default:
                    break;
            }
        } while (run);
    }
}