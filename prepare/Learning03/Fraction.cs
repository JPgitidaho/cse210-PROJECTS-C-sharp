using System;


public class Fraction
{
    private int numerator;   // The numerator of the fraction
    private int denominator; // The denominator of the fraction

    // Default constructor that sets the fraction to 1/1
    public Fraction() : this(1, 1)
    {
    }

    // Constructor for a whole number (e.g., 5 becomes 5/1)
    public Fraction(int wholeNumber) : this(wholeNumber, 1)
    {
    }

    // Constructor that takes both a numerator and a denominator
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.Denominator = denominator; // Use the setter to ensure the denominator is not zero
    }

    // Property for getting and setting the numerator
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    // Property for getting and setting the denominator
    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value != 0)
                denominator = value;
            else
                throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Method to get the string representation of the fraction (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
