using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("请输入矩阵的行数和列数：");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("请输入矩阵的元素（每行元素用空格分隔）：");
        for (int i = 0; i < rows; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(inputs[j]);
            }
        }

        bool result = IsToeplitzMatrix(matrix);
        Console.WriteLine($"该矩阵是托普利茨矩阵吗？{result}");
    }

    static bool IsToeplitzMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                if (matrix[i, j] != matrix[i + 1, j + 1])
                {
                    return false; // 如果不相等，则不是托普利茨矩阵
                }
            }
        }

        return true; // 所有对角线元素相等，是托普利茨矩阵
    }
}
