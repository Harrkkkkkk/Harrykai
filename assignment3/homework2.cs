using System;
using System.Collections.Generic;

// 定义一个接口，包含计算面积和判断形状是否合法的方法
public interface IShape
{
    bool IsValid();
    double Area();
    string ShapeType { get; }
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

    public string ShapeType => "长方形";
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

    public string ShapeType => "正方形";
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

    public string ShapeType => "三角形";
}

// 简单工厂类，用于创建形状对象
public class ShapeFactory
{
    private Random random = new Random();

    public IShape CreateShape()
    {
        // 随机选择形状类型
        int shapeType = random.Next(3);
        switch (shapeType)
        {
            case 0:
                // 创建长方形，随机生成 1 到 10 之间的长和宽
                double length = random.NextDouble() * 9 + 1;
                double width = random.NextDouble() * 9 + 1;
                return new Rectangle(length, width);
            case 1:
                // 创建正方形，随机生成 1 到 10 之间的边长
                double side = random.NextDouble() * 9 + 1;
                return new Square(side);
            case 2:
                // 创建三角形，随机生成 1 到 10 之间的三条边
                double side1 = random.NextDouble() * 9 + 1;
                double side2 = random.NextDouble() * 9 + 1;
                double side3 = random.NextDouble() * 9 + 1;
                return new Triangle(side1, side2, side3);
            default:
                return null;
        }
    }
}

class Program
{
    static void Main()
    {
        ShapeFactory factory = new ShapeFactory();
        List<IShape> shapes = new List<IShape>();

        // 随机创建 10 个形状对象
        for (int i = 0; i < 10; i++)
        {
            IShape shape = factory.CreateShape();
            shapes.Add(shape);
        }

        double totalArea = 0;
        // 计算所有形状对象的面积之和，并输出每个形状的信息
        foreach (IShape shape in shapes)
        {
            if (shape.IsValid())
            {
                double area = shape.Area();
                totalArea += area;
                Console.WriteLine($"形状类型: {shape.ShapeType}，面积: {area}");
            }
            else
            {
                Console.WriteLine($"形状类型: {shape.ShapeType}，是否合法: false");
            }
        }

        Console.WriteLine($"10 个形状对象的面积之和为: {totalArea}");
    }
}