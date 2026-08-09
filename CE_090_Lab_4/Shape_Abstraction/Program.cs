using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    private int radius;

    public Circle(int radius) : base()
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private int length;
    private int breadth;

    public Rectangle(int length, int breadth) : base()
    {
        this.length = length;
        this.breadth = breadth;
    }

    public override double CalculateArea()
    {
        return length * breadth;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(5);
        Rectangle r1 = new Rectangle(5, 10);

        Console.WriteLine("Area of Circle : " + c1.CalculateArea());
        Console.WriteLine("Area of Rectangle : " + r1.CalculateArea());
    }
}