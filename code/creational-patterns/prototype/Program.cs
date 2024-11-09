using System;

public interface IShapePrototype
{
    IShapePrototype Clone();
}

public class Circle : IShapePrototype
{
    private double radius;

    private Circle(double radius)
    {
        this.radius = radius;
    }

    public static Circle Create(double radius)
    {
        return new Circle(radius);
    }

    private double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Circle - Radius: {radius}, Area: {CalculateArea()}");
    }

    public IShapePrototype Clone()
    {
        return Circle.Create(this.radius);
    }
}

public class Rectangle : IShapePrototype
{
    private double length;
    private double width;

    private Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public static Rectangle Create(double length, double width)
    {
        return new Rectangle(length, width);
    }

    private double CalculateArea()
    {
        return length * width;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Rectangle - Length: {length}, Width: {width}, Area: {CalculateArea()}");
    }

    public IShapePrototype Clone()
    {
        return Rectangle.Create(this.length, this.width);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create prototype objects
        Circle circlePrototype = Circle.Create(5);
        Rectangle rectanglePrototype = Rectangle.Create(4, 6);

        // Clone objects
        Circle clonedCircle = (Circle)circlePrototype.Clone();
        Rectangle clonedRectangle = (Rectangle)rectanglePrototype.Clone();

        // Display info
        clonedCircle.DisplayInfo();
        clonedRectangle.DisplayInfo();
    }
}
