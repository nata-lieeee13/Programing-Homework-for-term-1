namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Ask the user to enter the width and height
        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        //Create an instance for the rectangle
        Rectangle rectangle = new Rectangle(width,height);

        double area = rectangle.CalculateArea();
        double perimeter = rectangle.CalculatePerimeter();

        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");

        Console.ReadLine();
    }
}

