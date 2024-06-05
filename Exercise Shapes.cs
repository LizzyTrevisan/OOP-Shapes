using System;

public abstract class Shape
{
    public abstract double Area { get; }
    public string Name { get; set; }
    public abstract void Draw();

    public void Display()
    {
        Console.WriteLine("Displaying " + Name);
    }

    public Shape(string name)
    {
        this.Name = name;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public override double Area
    {
        get
        {
            return radius * radius * Math.PI;
        }
    }

    public override void Draw()
    {
        Console.WriteLine($"Draw a cricle of {radius}.");
    }

}

public class Rectangle : Shape

{
    private double length;
    private double width;

    public Rectangle(string name, double length, double width) : base(name)  //base means the parent  inherating to Shape
    {
        this.length = length;
        this.width = width;
    }

    public override double Area
    {
        get
        {
            return length * width;
        }
    }
    public override void Draw()
    {
        Console.WriteLine($"Draw a rectangle of {Area} ");

    }

}

public class Triangle : Shape
{
        
    private double sideA =3;
    private double sideB = 5;
    private double sideC = 3;

    public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
    {
    }

    public override double Area
{
    get
    {
        double s = (sideA + sideB + sideC) / 2; // this is the formula to calculate perimeter
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));//Heron's formula
    }
}
public override void Draw()
{
    Console.WriteLine($"Draw a Triangle of {Name}, side a {sideA}, side b {sideB}, side c { sideC}");

}
}





    internal class Program
{
    static void Main(string[] args)
    {

        Circle c = new Circle("Circle", 5);
        c.Display();
        c.Draw();
        Console.WriteLine("Area: " + Math.Round(c.Area,2) + "\n");


        Rectangle r = new Rectangle("Rectangle", 6,3);
        r.Display();
        r.Draw();
        Console.WriteLine($"Area: " + r.Area + "\n");

        Triangle t = new Triangle("Triangle", 3, 5, 3);
        t.Display();
        t.Draw();
        Console.WriteLine($"Area: " + Math.Round(t.Area,2) + "\n");
        ;
    }
}