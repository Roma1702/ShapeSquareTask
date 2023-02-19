using SquareCalculator.Models.Abstraction;

namespace SquareCalculator.Models;

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override bool IsValid()
    {
        var conditionFirst = SideA + SideB > SideC;
        var conditionSecond = SideB + SideC > SideA;
        var conditionThird = SideC + SideA > SideB;
        var conditionFourth = SideA > 0 && SideB > 0 && SideC > 0;

        return conditionFirst &&
               conditionSecond &&
               conditionThird &&
               conditionFourth;
    }

    public override double GetSquare()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;

        var squareSquaredValue = semiPerimeter * (semiPerimeter - SideA) *
                                          (semiPerimeter - SideB) *
                                          (semiPerimeter - SideC);

        var square = Math.Sqrt(squareSquaredValue);

        return square;
    }

    public bool IsRectangular()
    {
        var listOfSides = new List<double> { SideA, SideB, SideC };

        var hypotenuse = listOfSides.Max();

        listOfSides = listOfSides.Where(x => x != hypotenuse).ToList();

        var sumOfSidesSquared = listOfSides.Sum(x => Math.Pow(x, 2));

        var condition = Math.Pow(hypotenuse, 2) == sumOfSidesSquared;

        return condition;
    }

    public override string ToString()
    {
        return $"{GetType().Name}";
    }
}
