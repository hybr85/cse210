using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name > ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number > ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int x)
    {
        return x*x;
    }
    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, your number squared is {num}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}