using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        int num;

        Console.WriteLine("Enter numbers, 0 when finished.");
        do {
            Console.Write("Enter number > ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        } while(num != 0);
        
        numbers.Remove(0);
        Console.WriteLine($"Sum: {numbers.Sum()}, avg: {numbers.Average()}, max: {numbers.Max()}");
        numbers.Sort();
        foreach (int i in numbers) Console.Write($"{i} ");
        Console.WriteLine();
    }
}