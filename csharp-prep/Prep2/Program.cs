using System;

class Program
{
    static void Main(string[] args)
    {
        string grades = "FDCBA";
        
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());
        int idx = Math.Clamp(percent / 10 - 5, 0, 4);

        Console.WriteLine($"{grades[idx]}{(percent>93||percent<60?null:(percent%10>=7?'+':(percent%10<3?'-':null)))}");
        Console.WriteLine(percent>=70?"Yay you passed!":"You can do it next time!");
    }
}