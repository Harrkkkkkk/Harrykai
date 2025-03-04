/*using System;

class Program
{
    static void Main()
    {
        // 输入数组的大小
        Console.WriteLine("请输入数组的大小：");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("请输入一个有效的正整数。");
        }

        int[] numbers = new int[size];

        // 输入数组元素
        Console.WriteLine($"请输入 {size} 个整数：");
        for (int i = 0; i < size; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("请输入一个有效的整数。");
            }
        }

        // 计算最大值、最小值、和、平均值
        int max = numbers[0];
        int min = numbers[0];
        int sum = 0;

        foreach (int number in numbers)
        {
            if (number > max)
                max = number;
            if (number < min)
                min = number;

            sum += number;
        }

        double average = (double)sum / size;

        // 输出结果
        Console.WriteLine($"最大值: {max}");
        Console.WriteLine($"最小值: {min}");
        Console.WriteLine($"所有元素的和: {sum}");
        Console.WriteLine($"平均值: {average}");
    }
}
*/