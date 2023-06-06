using Area.Figures;

namespace Area.Counter;

public class AreaCounter
{
    public double CountArea(params double[] values)
    {
        return values.Length switch
        {
            1 => new Circle(values[0]).CountArea(),
            3 => new Triangle(values).CountArea(),
            _ => throw new ArgumentException("No figures")
        };
    }
}