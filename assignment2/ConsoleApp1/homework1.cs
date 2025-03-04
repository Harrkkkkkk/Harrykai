/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("请输入一个整数：");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
        {
            List<int> primeFactors = GetPrimeFactors(number);
            Console.WriteLine($"数字 {number} 的素数因子有：{string.Join(", ", primeFactors)}");
        }
        else
        {
            Console.WriteLine("请输入一个大于 1 的有效整数。");
        }
    }

    static List<int> GetPrimeFactors(int number)
    {
        List<int> factors = new List<int>();
        // 从 2 开始检查因子
        for (int i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                if (!factors.Contains(i))
                {
                    factors.Add(i); // 添加素数因子
                }
                number /= i; // 除以因子
            }
        }
        return factors;
    }
}
*/