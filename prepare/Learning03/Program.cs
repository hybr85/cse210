using System;

class Program
{
    static void Main(string[] args)
    {
        var frac1 = new Fraction();
        var frac2 = new Fraction(4);
        var frac3 = new Fraction(9, 7);

        Console.Write($"{frac1.GetFractionString()}\n{frac1.GetDecimalValue()}\n{frac2.GetFractionString()}\n{frac2.GetDecimalValue()}\n{frac3.GetFractionString()}\n{frac3.GetDecimalValue()}\n");
    }
}