using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;

        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");

    }
}