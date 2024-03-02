class Program
{
    static void Main(string[] args)
    {
        Breathing breathing;
        Reflecting reflecting;
        Listing listing;
        int choice;

        while (true) {
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nEnter choice > ");
            choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    breathing = new Breathing();
                    breathing.Welcome();
                    breathing.Breathe();
                    breathing.Ending();
                break;

                case 2:
                    reflecting = new Reflecting();
                    reflecting.Welcome();
                    reflecting.Reflect();
                    reflecting.Ending();
                break;

                case 3:
                    listing = new Listing();
                    listing.Welcome();
                    listing.List();
                    listing.Ending();
                break;

                case 4: return;
                default: throw new ArgumentException("Invalid selection");
            }
        }
    }
}