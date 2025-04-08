namespace AreaFinder;

public class ForSquare
{
    public int length { get; set; }

    public ForSquare(int value)
    {
        this.length = value;
    }
    public int AreaCalc()
    {
        return (length * length);
    }
}