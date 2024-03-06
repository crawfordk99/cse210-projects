using System;

class Program
{
    static void Main(string[] args)
    {
       Square square = new Square("Blue", 3);
       Rectangle rectangle = new Rectangle("Orange", 4, 4.5);
       Circle circle= new Circle("Red", 3.5);
       Console.WriteLine(square.GetColor());
       Console.WriteLine(square.GetArea());
       Console.WriteLine(rectangle.GetColor());
       Console.WriteLine(rectangle.GetArea());
       Console.WriteLine(circle.GetColor());
       Console.WriteLine(circle.GetArea());
       
    }
}