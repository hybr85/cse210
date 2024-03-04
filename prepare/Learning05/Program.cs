using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        shapes.Add(new Square("brown", 5.1));
        shapes.Add(new Rectangle("red", 2.1, 7.1));
        shapes.Add(new Circle("blue", 4.1));

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor()+" "+shape.GetArea());
        }
    }
}