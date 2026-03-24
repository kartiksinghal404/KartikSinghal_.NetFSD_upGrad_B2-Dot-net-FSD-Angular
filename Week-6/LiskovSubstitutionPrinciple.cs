using System;

// Base Class (Abstraction)
public abstract class Shape
{
    public abstract double CalculateArea();
}

// Rectangle Class
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

// Circle Class
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Area Calculator Class
public class AreaCalculator
{
    public void PrintArea(Shape shape)
    {
        Console.WriteLine("Area: " + shape.CalculateArea());
    }
}

// Main Program
class Program
{
    static void Main()
    {
        AreaCalculator calculator = new AreaCalculator();

        // Taking Rectangle input
        Console.WriteLine("Enter Rectangle Length:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Rectangle Width:");
        double width = Convert.ToDouble(Console.ReadLine());

        Shape rectangle = new Rectangle(length, width);
        calculator.PrintArea(rectangle);

        // Taking Circle input
        Console.WriteLine("\nEnter Circle Radius:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Shape circle = new Circle(radius);
        calculator.PrintArea(circle);
    }
}