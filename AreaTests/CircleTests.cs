using Area.Figures;

namespace AreaTests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void CircleWithZeroR()
    {
        Figure figure = new Circle(0);
        Assert.That(figure.CountArea(), Is.EqualTo(0));
    }

    [Test]
    public void CircleWithNegativeRThrowsArgumentException()
    {
        Assert.That(() => new Circle(-3), Throws.TypeOf<ArgumentException>());
    }

    [TestCase(4d, 50.2654824574d)]
    [TestCase(9d, 254.469004941d)]
    [TestCase(15.5d, 754.767635025d)]
    [TestCase(23.44d, 1726.0965614d)]
    public void RandomCircles(double r, double ans)
    {
        Figure figure = new Circle(r);
        Assert.That(figure.CountArea(), Is.EqualTo(ans).Within(1e-8));
    }
}