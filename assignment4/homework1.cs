/*using System;

public class Node<T>
{
    public T Data;
    public Node<T> Next;

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    public LinkedList()
    {
        head = null;
    }

    public void Add(T data)
    {
        var newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void ForEach(Action<T> action)
    {
        var current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList<int>();

        Console.WriteLine("请输入整数（输入 'exit' 结束）：");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                list.Add(number);
            }
            else
            {
                Console.WriteLine("无效输入，请输入一个整数。");
            }
        }

        // 打印链表元素
        Console.WriteLine("链表元素:");
        list.ForEach(x => Console.WriteLine(x));

        // 求最大值
        int max = int.MinValue;
        list.ForEach(x => {
            if (x > max) max = x;
        });
        Console.WriteLine($"最大值: {max}");

        // 求最小值
        int min = int.MaxValue;
        list.ForEach(x => {
            if (x < min) min = x;
        });
        Console.WriteLine($"最小值: {min}");

        // 求和
        int sum = 0;
        list.ForEach(x => sum += x);
        Console.WriteLine($"求和: {sum}");
    }
}
*/