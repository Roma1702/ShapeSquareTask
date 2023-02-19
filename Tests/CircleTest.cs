using SquareCalculator.Models;

namespace Tests
{
    public class CircleTest
    {
        private readonly Fixture _fixture;

        public CircleTest()
        {
            _fixture= new Fixture();
        }

        [Fact]
        public void CircleTestsWhenRadiusIsValid()
        {
            var circle = _fixture.Create<Circle>();
            var expectedResult = Math.Pow(circle.Radius, 2) * Math.PI;

            var square = circle.GetSquare();

            circle.IsValid().Should().BeTrue();
            square.Should().Be(expectedResult);
        }

        [Fact]
        public void CircleTestsWhenRadiusIsNotValid()
        {
            var circle = new Circle(-7);

            var isValid = circle.IsValid();

            isValid.Should().BeFalse();
        }
    }
}