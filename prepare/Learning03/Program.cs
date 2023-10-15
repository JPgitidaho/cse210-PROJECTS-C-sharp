using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();         // Create a fraction 1/1
        Fraction fraction2 = new Fraction(5);        // Create a fraction 5/1
        Fraction fraction3 = new Fraction(3, 4);     // Create a fraction 3/4

        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString());

        Console.WriteLine("Decimal value of Fraction 1: " + fraction1.GetDecimalValue());
        Console.WriteLine("Decimal value of Fraction 2: " + fraction2.GetDecimalValue());
        Console.WriteLine("Decimal value of Fraction 3: " + fraction3.GetDecimalValue());

        // Change the numerator and denominator of fraction 1
        fraction1.Numerator = 2;
        fraction1.Denominator = 3;

        Console.WriteLine("Updated Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Updated Decimal value of Fraction 1: " + fraction1.GetDecimalValue());
    }
}
