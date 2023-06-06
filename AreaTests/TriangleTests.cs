using Area.Figures;

namespace AreaTests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void TestRightTriangle()
    {
        Figure figure = new Triangle(4, 5, 3);
        Assert.That(figure.CountArea(), Is.EqualTo(6));
    }

    [Test]
    public void TriangleWithNegativeThrowsArgumentException()
    {
        Assert.That(() => new Triangle(5, -3, 2), Throws.TypeOf<ArgumentException>());
    }

    [TestCase(4.5, 2.2, 6, 4.13076793707)]
    [TestCase(5, 3, 3, 4.145780987944)]
    [TestCase(20, 28, 31, 274.3937635953)]
    [TestCase(33, 56, 46, 758.803951953)]
    public void RandomTriangles(double a, double b, double c, double ans)
    {
        Figure figure = new Triangle(a, b, c);
        Assert.That(figure.CountArea(), Is.EqualTo(ans).Within(1e-8));
    }

    [Test]
    public void ObtuseTriangle()
    {
        Figure figure = new Triangle(9, 5, 6);
        Assert.That(figure.CountArea(), Is.EqualTo(Math.Sqrt(2) * 10).Within(1e-9));
    }
}