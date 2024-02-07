using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.SetLength(2);
        rectangle.SetWidth(4);
        rectangle.SetColor("blue");

        Square square = new Square();
        square.SetSide(5);
        square.SetColor("pink");

        Circle circle = new Circle();
        circle.SetRadius(7);
        circle.SetColor("black");

        Console.WriteLine("\n");
        Console.WriteLine($"The {square.GetColor()} square's area is {square.GetArea()} units squared.\n");
        Console.WriteLine($"The {rectangle.GetColor()} rectangle's area is {rectangle.GetArea()} units squared.\n");
        Console.WriteLine($"The {circle.GetColor()} circle's area is {circle.GetArea()} units squared.\n\n");
    }
}