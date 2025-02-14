using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("Red", 5));
        shapes.Add(new Rectangle("Blue", 5, 10));
        shapes.Add(new Square("Green", 5));

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}