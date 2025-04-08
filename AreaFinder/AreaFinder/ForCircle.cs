namespace AreaFinder;

public class ForCircle
{
    public double radius { get; set; }

    public ForCircle(double value)
    {
        radius = value;
    }

    public double AreaCalc()
    {
        double area = 3.14 * (radius * radius);
        return area;
    }
}