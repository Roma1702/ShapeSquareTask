using SquareCalculator.Models.Abstraction;

namespace SquareCalculator.Models;

public class Rectangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public override double GetSquare()
    {
        return SideA * SideB;
    }

    public override bool IsValid()
    {
        return SideA > 0 && SideB > 0;
    }

    public override string ToString()
    {
        return $"{GetType().Name}";
    }
}
