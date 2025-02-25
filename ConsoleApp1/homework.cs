using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        char op;

        // 获取用户输入
        Console.Write("请输入第一个数字: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("请输入运算符 (+, -, *, /): ");
        op = Console.ReadKey().KeyChar; // 读取单个字符作为运算符
        Console.WriteLine(); // 换行

        Console.Write("请输入第二个数字: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // 计算并输出结果
        switch (op)
        {
            case '+':
                Console.WriteLine("结果: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("结果: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("结果: " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine("结果: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("错误: 除数不能为零!");
                }
                break;
            default:
                Console.WriteLine("错误: 无效的运算符!");
                break;
        }

        // 等待用户输入以便查看结果
        Console.WriteLine("按任意键退出...");
        Console.ReadKey();
    }
}

