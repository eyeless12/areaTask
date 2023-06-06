using Area;
using Area.Counter;

namespace AreaTests;

[TestFixture]
public class AreaCounterTests
{
    [SetUp]
    public void SetUp()
    {
        _counter = new AreaCounter();
    }

    private AreaCounter _counter;

    [TestCase(4d, 50.2654824574d)]
    [TestCase(9d, 254.469004941d)]
    [TestCase(15.5d, 754.767635025d)]
    [TestCase(23.44d, 1726.0965614d)]
    public void TestCircles(double r, double ans)
    {
        Assert.That(ans, Is.EqualTo(_counter.CountArea(r)).Within(1e-8));
    }

    [TestCase(4.5, 2.2, 6, 4.13076793707)]
    [TestCase(5, 3, 3, 4.145780987944)]
    [TestCase(20, 28, 31, 274.3937635953)]
    [TestCase(33, 56, 46, 758.803951953)]
    public void TestTriangles(double a, double b, double c, double ans)
    {
        Assert.That(ans, Is.EqualTo(_counter.CountArea(a, b, c)).Within(1e-8));
    }

    [Test]
    public void WrongFigureThrowsArgumentException()
    {
        Assert.That(() => _counter.CountArea(1, 2), Throws.TypeOf<ArgumentException>());
    }
}