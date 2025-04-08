using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Orange",5);
        Rectangle rectangle = new Rectangle("Brown",5,10);
        Circle circle = new Circle("Purple",14);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"color: {shape.GetColor()}");
            Console.WriteLine($"area: {shape.GetArea()}");
            Console.WriteLine("");
        }
    }
}