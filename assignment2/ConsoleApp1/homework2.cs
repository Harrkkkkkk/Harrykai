/*using System;

class Program
{
    static void Main()
    {
        int max = 100;
        bool[] isPrime = new bool[max + 1];

        // 初始化所有数为素数
        for (int i = 2; i <= max; i++)
        {
            isPrime[i] = true;
        }

        // 埃氏筛法
        for (int p = 2; p * p <= max; p++)
        {
            if (isPrime[p])
            {
                // 去掉 p 的倍数
                for (int multiple = p * p; multiple <= max; multiple += p)
                {
                    isPrime[multiple] = false;
                }
            }
        }

        // 输出所有素数
        Console.WriteLine("2 到 100 之间的素数有：");
        for (int i = 2; i <= max; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
*/