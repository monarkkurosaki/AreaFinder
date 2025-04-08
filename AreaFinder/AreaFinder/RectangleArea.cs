namespace AreaFinder;

public class RectangleArea
{
    public int length { get; set; }
    public int breadth { get; set; }

    public RectangleArea(int Length, int Breadth)
    {
        length = Length;
        breadth = Breadth;
    }

    public int AreaCalc()
    {
        return length * breadth;
    }
}