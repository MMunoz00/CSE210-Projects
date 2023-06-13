using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!\n");

        var square = new Square("Green", 25);
        var rectangle = new Rectangle("Red", 10, 20);
        var circle = new Circle("Blue", 15);

        var shapes = new List<Shape> {square, rectangle, circle};

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape);
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }

    }
}

class Shape{
    protected string _color;

    public Shape(string color){
        _color = color;
    }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color = color;
    }

    virtual public double GetArea() {
        return 0;        
    }
}

class Square: Shape {
    private double _side;

    public Square(string color, double side): base(color) {
        _side = side;
    }

    public override double GetArea() {
        return (_side * _side);
    }
}

class Rectangle: Shape {
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width): base(color) {
        _length = length;
        _width = width;
    }

    public override double GetArea() {
        return (_length * _width);
    }
}

class Circle: Shape {
    private double _radius;
    private double _pi = Math.PI;

    public Circle(string color, double radius): base(color) {
        _radius = radius;
    }

    public override double GetArea() {
        return Math.Round((_pi * (_radius * _radius)), 2);
    }
}