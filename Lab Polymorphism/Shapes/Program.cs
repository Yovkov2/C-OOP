namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5, 4);
            Shape circle = new Circle(3);

            Console.WriteLine(rectangle.Draw());
            Console.WriteLine($"Perimeter of Rectangle: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");

            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Perimeter of Circle: {circle.CalculatePerimeter()}");
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
        }
    }
}