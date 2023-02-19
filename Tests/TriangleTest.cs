using SquareCalculator.Models;

namespace Tests;

public class TriangleTest
{
    [Fact]
    public void SquareTestCorrectResult()
    {
        var triangle = new Triangle(5, 5, 6);
        var exceptedSquare = 12;

        var square = triangle.GetSquare();

        square.Should().Be(exceptedSquare);
    }

    [Fact]
    public void TestNotValidSides()
    {
        var triangle = new Triangle(1, -7, 3);

        var isValid = triangle.IsValid();

        isValid.Should().BeFalse();
    }

    [Fact]
    public void TestIsRectangular()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRectangular = triangle.IsRectangular();

        isRectangular.Should().BeTrue();
    }
}
