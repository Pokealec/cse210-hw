using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Square square = new(25, "Blue");
        // double area = square.GetArea();
        // Console.WriteLine(area);

        // Rectangle rectangle = new(2, 4, "Yellow");
        // double area2 = rectangle.GetArea();
        // Console.WriteLine(area2);

        // Circle circle = new(25, "Red");
        // double area3 = circle.GetArea();
        // Console.WriteLine(area3);

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(3, "Red");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(4, 5, "Blue");
        shapes.Add(s2);

        Circle s3 = new Circle(6, "Green");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}