class Program
{
    static int Menu()
    {
        Console.Write("Options:\n  1. New goal\n  2. List\n  3. Save\n  4. Load\n  5. Record event\n  6. Quit\nEnter choice > ");
        return int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        Console.Clear();
        int score = 0;
        List<Goal> goals = new();
        string name;

        while (true) {
            //Console.Clear();
            Console.Write($"{score} points\n\n");

            switch (Menu()) {
                case 1: // new
                    Console.Clear();

                    Console.Write("Goal types:\n  1. Simple\n  2. Eternal\n  3. Checklist\nEnter choice > ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Write("Goal title > ");
                    string title = Console.ReadLine();
                    Console.Write("Goal description > ");
                    string description = Console.ReadLine();
                    Console.Write("Completion points > ");
                    int points = int.Parse(Console.ReadLine());

                    switch (choice) {
                        case 1:
                            goals.Add(new Goal(title, description, points));
                        break;

                        case 2:
                            goals.Add(new Eternal(title, description, points));
                        break;

                        case 3:
                            Console.Write("How many times > ");
                            int count = int.Parse(Console.ReadLine());
                            Console.Write("Bonus points > ");
                            int bonus = int.Parse(Console.ReadLine());
                            goals.Add(new Checklist(title, description, points, count, bonus));
                        break;

                        default: throw new ArgumentException("Not a choice");
                    }
                    Console.Clear();
                break;

                case 2: // list
                    Console.Clear();
                    int c = 1;
                    foreach (Goal goal in goals)
                        Console.Write($"{c++}. {goal.Display()}\n");
                    Console.Write("\n");
                break;

                case 3: // save
                    Console.Write("File name > ");
                    name = Console.ReadLine();
                    using (StreamWriter file = new(name)) {
                        file.WriteLine(score);
                        foreach (Goal goal in goals) file.WriteLine(goal.Export());
                    }
                    Console.Clear();
                break;

                case 4: // load
                    Console.Write("File name > ");
                    name = Console.ReadLine();
                    string[] lines = File.ReadAllLines(name);
                    score += int.Parse(lines[0]);

                    foreach (string line in lines) {
                        if (line == lines[0]) continue;
                        string[] parts = line.Split(':');
                        switch (parts[0]) {
                            case "":
                                goals.Add(new Goal(parts[1]));
                            break;

                            case "Eternal":
                                goals.Add(new Eternal(parts[1]));
                            break;

                            case "Checklist":
                                goals.Add(new Checklist(parts[1]));
                            break;

                            default: throw new ArgumentException("Invalid file");
                        }
                    }
                    Console.Clear();
                break;

                case 5: // record
                    Console.Clear();
                    int d = 1;
                    foreach (Goal goal in goals)
                        Console.Write($"{d++}. {goal.DisplayShort()}\n");
                    Console.Write("Which goal > ");
                    int goalChoice = int.Parse(Console.ReadLine());
                    int pointsEarned = goals[goalChoice-1].RecordEvent();
                    score += pointsEarned;
                    Console.Clear();
                    Console.Write($"You earned {pointsEarned} points\n\n");
                break;

                case 6: return; // quit
                default: throw new ArgumentException("Not a choice");
            }
        }
    }
}