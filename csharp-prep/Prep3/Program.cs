using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100);
        int guess;
        int numGuesses = 0;
        
        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numGuesses++;

            if(guess>random) Console.WriteLine("Lower");
            if(guess<random) Console.WriteLine("Higher");
        } while(guess!=random);
        Console.WriteLine($"You guessed it!\nIt took you {numGuesses} guesses");
    }
}