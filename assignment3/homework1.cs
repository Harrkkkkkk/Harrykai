/*using System;

// 定义一个接口，包含计算面积和判断形状是否合法的方法
public interface IShape
{
    bool IsValid();
    double Area();
}

// 长方形类
public class Rectangle : IShape
{
    // 私有字段存储长和宽
    private double length;
    private double width;

    // 公共属性，提供对长和宽的访问
    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    // 构造函数，初始化长和宽
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // 判断长方形是否合法（长和宽都必须大于 0）
    public bool IsValid()
    {
        return length > 0 && width > 0;
    }

    // 计算长方形的面积
    public double Area()
    {
        if (IsValid())
        {
            return length * width;
        }
        return 0;
    }
}

// 正方形类
public class Square : IShape
{
    // 私有字段存储边长
    private double side;

    // 公共属性，提供对边长的访问
    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    // 构造函数，初始化边长
    public Square(double side)
    {
        this.side = side;
    }

    // 判断正方形是否合法（边长必须大于 0）
    public bool IsValid()
    {
        return side > 0;
    }

    // 计算正方形的面积
    public double Area()
    {
        if (IsValid())
        {
            return side * side;
        }
        return 0;
    }
}

// 三角形类
public class Triangle : IShape
{
    // 私有字段存储三条边
    private double side1;
    private double side2;
    private double side3;

    // 公共属性，提供对三条边的访问
    public double Side1
    {
        get { return side1; }
        set { side1 = value; }
    }

    public double Side2
    {
        get { return side2; }
        set { side2 = value; }
    }

    public double Side3
    {
        get { return side3; }
        set { side3 = value; }
    }

    // 构造函数，初始化三条边
    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    // 判断三角形是否合法（任意两边之和大于第三边，且边长都大于 0）
    public bool IsValid()
    {
        return side1 > 0 && side2 > 0 && side3 > 0 &&
               side1 + side2 > side3 &&
               side1 + side3 > side2 &&
               side2 + side3 > side1;
    }

    // 使用海伦公式计算三角形的面积
    public double Area()
    {
        if (IsValid())
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        return 0;
    }
}

class Program
{
    static void Main()
    {
        // 输入长方形的长和宽
        Console.WriteLine("请输入长方形的长:");
        double rectangleLength = double.Parse(Console.ReadLine());
        Console.WriteLine("请输入长方形的宽:");
        double rectangleWidth = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(rectangleLength, rectangleWidth);
        Console.WriteLine($"长方形是否合法: {rectangle.IsValid()}");
        Console.WriteLine($"长方形的面积: {rectangle.Area()}");

        // 输入正方形的边长
        Console.WriteLine("请输入正方形的边长:");
        double squareSide = double.Parse(Console.ReadLine());
        Square square = new Square(squareSide);
        Console.WriteLine($"正方形是否合法: {square.IsValid()}");
        Console.WriteLine($"正方形的面积: {square.Area()}");

        // 输入三角形的三条边
        Console.WriteLine("请输入三角形的第一条边长:");
        double triangleSide1 = double.Parse(Console.ReadLine());
        Console.WriteLine("请输入三角形的第二条边长:");
        double triangleSide2 = double.Parse(Console.ReadLine());
        Console.WriteLine("请输入三角形的第三条边长:");
        double triangleSide3 = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);
        Console.WriteLine($"三角形是否合法: {triangle.IsValid()}");
        Console.WriteLine($"三角形的面积: {triangle.Area()}");
    }
}*/