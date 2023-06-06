using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AreaTests")]

namespace Area.Figures;

/// <summary>
///     Basic figure class. Add custom figures by inheriting from this class.
/// </summary>
internal abstract class Figure
{
    public abstract double CountArea();
}