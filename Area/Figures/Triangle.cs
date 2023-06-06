namespace Area.Figures;

internal class Triangle : Figure
{
    public Triangle(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a ||
            a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Triangle doesn't exists");

        var sides = new[] { a, b, c };
        Array.Sort(sides);
        if (Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] -
                     sides[2] * sides[2]) < 1e-9)
            IsRight = true;

        A = sides[0];
        B = sides[1];
        C = sides[2];
    }

    public Triangle(IReadOnlyList<double> values) : this(values[0], values[1], values[2])
    {
    }

    private double A { get; }
    private double B { get; }
    private double C { get; }
    private bool IsRight { get; }

    public override double CountArea()
    {
        if (IsRight) return A * B / 2;
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}