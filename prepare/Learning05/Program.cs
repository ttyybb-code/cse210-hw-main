using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        Rectangle rectangle = new Rectangle(3,7);
        Circle circle = new Circle (3);
        List<Shape> shapes = new List<Shape>{square, rectangle, circle};
        square.SetColor("red");
        rectangle.SetColor("yellow");
        circle.SetColor("pink");

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}