// MainProgram.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 2),
            new Rectangle("Blue", 3, 4),
            new Circle("Yellow", 5)
        };

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.Color}");
            Console.WriteLine($"Area: {s.GetArea()}");
            Console.WriteLine();
        }
    }
}
