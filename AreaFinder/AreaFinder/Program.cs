namespace AreaFinder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the area calculator");
        Console.WriteLine("To find area of rectangle press r, for sqaure s and circle c");

        string userSelect = Console.ReadLine();
        if (userSelect.Equals("s"))
        {
            Console.Write("Enter the length of square: ");
            int squareLength = Convert.ToInt32(Console.ReadLine());
            
            ForSquare area = new ForSquare(squareLength);
            Console.WriteLine("The area of square is "+area.AreaCalc());
        }else if (userSelect.Equals('r'))
        {
            Console.Write("Enter the length of rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the breadth of rectangle: ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            if (length.Equals(breadth))
            {
                Console.WriteLine("It is not a rectangle it is a sqaure");
                Environment.Exit(0);
            }
            else
            {
                RectangleArea rect = new RectangleArea(length, breadth);
                Console.WriteLine("Area of rectangle is : "+rect.AreaCalc());
            }
        }else if (userSelect.Equals('c'))
        {
            
        }
        else
        {
            Console.WriteLine("The input is invalid please try again");
        }
    }
}