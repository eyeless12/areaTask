namespace Area.Figures;

internal class Circle : Figure
{
    public Circle(double r)
    {
        if (r < 0) throw new ArgumentException("Circle doesn't exists");
        R = r;
    }

    private double R { get; }

    public override double CountArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }
}