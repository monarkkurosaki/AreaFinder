namespace AreaFinder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the area calculator");
        Console.WriteLine("To find area of rectangle press r, for sqaure s and circle c");

        string userSelect = Console.ReadLine();
        if (userSelect.Equals('s'))
        {
            
        }else if (userSelect.Equals('r'))
        {
            
        }else if (userSelect.Equals('c'))
        {
            
        }
        else
        {
            Console.WriteLine("The input is invalid please try again");
        }
    }
}