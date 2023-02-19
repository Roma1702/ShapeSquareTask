using SquareCalculator.Models.Abstraction;

namespace SquareCalculator.Models;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override bool IsValid()
    {
        return Radius > 0;
    }

    public override double GetSquare()
    {
        var square = Math.PI* Math.Pow(Radius, 2);

        return square;
    }

    public override string ToString()
    {
        return $"{GetType().Name}";
    }
}
