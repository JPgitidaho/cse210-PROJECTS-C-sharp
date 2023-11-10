// Quadrilateral.cs
public class Quadrilateral : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public Quadrilateral(string color, double side1, double side2) : base(color)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public Quadrilateral(string color, double side1) : base(color)
    {
        Side1 = side1;
        Side2 = 0; // Default value, assuming it's not always a square
    }

    public override double GetArea()
    {
       
        return Side1 * Side2;
    }
}
