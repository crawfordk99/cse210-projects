using System;

class Program
{
    static void Main(string[] args)
    {
       Square square = new Square("Blue", 3);
       Rectangle rectangle = new Rectangle("Orange", 4, 4.5);
       Circle circle= new Circle("Red", 3.5);
       List<Shape> _shapes = new List<Shape>();
       _shapes.Add(square);
       _shapes.Add(rectangle);
       _shapes.Add(circle); 
       foreach (Shape shape in _shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
       }
    }
}