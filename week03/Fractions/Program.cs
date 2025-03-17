using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Fraction fractionOne = new Fraction();
        Fraction fractionTwo = new Fraction(5);
        Fraction fractionThree = new Fraction(3,5);

        Console.WriteLine($"Numerator: {fractionOne.GetNumerator()}");
        Console.WriteLine($"Denominator: {fractionOne.GetDenominator()}");
        fractionThree.SetNumerator(3);
        fractionThree.SetDenominator(4);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("-------------------------------");

        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());
        Console.WriteLine("-------------------------------");

        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());
        Console.WriteLine("-------------------------------");

        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());
        Console.WriteLine("-------------------------------");
    }
}