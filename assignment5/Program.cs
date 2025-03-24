using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        OrderService orderService = new OrderService();

        while (true)
        {
            Console.WriteLine("\n请选择操作：");
            Console.WriteLine("1. 添加订单");
            Console.WriteLine("2. 删除订单");
            Console.WriteLine("3. 修改订单");
            Console.WriteLine("4. 查询订单");
            Console.WriteLine("5. 按订单号排序");
            Console.WriteLine("6. 按订单总金额排序");
            Console.WriteLine("7. 显示所有订单");
            Console.WriteLine("8. 退出");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddOrder(orderService);
                    break;
                case "2":
                    DeleteOrder(orderService);
                    break;
                case "3":
                    UpdateOrder(orderService);
                    break;
                case "4":
                    QueryOrder(orderService);
                    break;
                case "5":
                    orderService.SortOrders();
                    Console.WriteLine("按订单号排序成功！");
                    break;
                case "6":
                    orderService.SortOrders((x, y) => x.TotalAmount.CompareTo(y.TotalAmount));
                    Console.WriteLine("按订单总金额排序成功！");
                    break;
                case "7":
                    var allOrders = orderService.GetAllOrders();
                    PrintOrders(allOrders);
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("无效的选择，请重新输入。");
                    break;
            }

            // 每次操作完成后清屏
            Console.WriteLine("\n按任意键继续...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void AddOrder(OrderService orderService)
    {
        try
        {
            Console.Write("请输入订单号：");
            int orderId = int.Parse(Console.ReadLine());
            Console.Write("请输入客户名称：");
            string customer = Console.ReadLine();

            List<OrderDetails> details = new List<OrderDetails>();
            while (true)
            {
                Console.Write("是否添加订单明细（y/n）：");
                string addDetails = Console.ReadLine();
                if (addDetails.ToLower() != "y")
                {
                    break;
                }

                Console.Write("请输入订单明细ID：");
                int detailId = int.Parse(Console.ReadLine());
                Console.Write("请输入商品名称：");
                string productName = Console.ReadLine();
                Console.Write("请输入商品价格：");
                double price = double.Parse(Console.ReadLine());
                Console.Write("请输入商品数量：");
                int quantity = int.Parse(Console.ReadLine());

                details.Add(new OrderDetails(detailId, productName, price, quantity));
            }

            Order order = new Order(orderId, customer, details);
            orderService.AddOrder(order);
            Console.WriteLine("添加订单成功！");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"添加订单失败: {ex.Message}");
        }
    }

    static void DeleteOrder(OrderService orderService)
    {
        try
        {
            Console.Write("请输入要删除的订单号：");
            int orderId = int.Parse(Console.ReadLine());
            orderService.DeleteOrder(orderId);
            Console.WriteLine("删除订单成功！");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"删除订单失败: {ex.Message}");
        }
    }

    static void UpdateOrder(OrderService orderService)
    {
        try
        {
            Console.Write("请输入要修改的订单号：");
            int orderId = int.Parse(Console.ReadLine());

            Console.Write("请输入新的客户名称：");
            string customer = Console.ReadLine();

            List<OrderDetails> details = new List<OrderDetails>();
            while (true)
            {
                Console.Write("是否添加订单明细（y/n）：");
                string addDetails = Console.ReadLine();
                if (addDetails.ToLower() != "y")
                {
                    break;
                }

                Console.Write("请输入订单明细ID：");
                int detailId = int.Parse(Console.ReadLine());
                Console.Write("请输入商品名称：");
                string productName = Console.ReadLine();
                Console.Write("请输入商品价格：");
                double price = double.Parse(Console.ReadLine());
                Console.Write("请输入商品数量：");
                int quantity = int.Parse(Console.ReadLine());

                details.Add(new OrderDetails(detailId, productName, price, quantity));
            }

            Order newOrder = new Order(orderId, customer, details);
            orderService.UpdateOrder(newOrder);
            Console.WriteLine("修改订单成功！");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"修改订单失败: {ex.Message}");
        }
    }

    static void QueryOrder(OrderService orderService)
    {
        Console.WriteLine("请选择查询方式：");
        Console.WriteLine("1. 按订单号查询");
        Console.WriteLine("2. 按商品名称查询");
        Console.WriteLine("3. 按客户查询");
        Console.WriteLine("4. 按订单金额查询");

        string queryChoice = Console.ReadLine();
        switch (queryChoice)
        {
            case "1":
                Console.Write("请输入订单号：");
                int orderId = int.Parse(Console.ReadLine());
                var ordersById = orderService.QueryByOrderId(orderId);
                PrintOrders(ordersById);
                break;
            case "2":
                Console.Write("请输入商品名称：");
                string productName = Console.ReadLine();
                var ordersByProduct = orderService.QueryByProductName(productName);
                PrintOrders(ordersByProduct);
                break;
            case "3":
                Console.Write("请输入客户名称：");
                string customer = Console.ReadLine();
                var ordersByCustomer = orderService.QueryByCustomer(customer);
                PrintOrders(ordersByCustomer);
                break;
            case "4":
                Console.Write("请输入订单金额：");
                double amount = double.Parse(Console.ReadLine());
                var ordersByAmount = orderService.QueryByTotalAmount(amount);
                PrintOrders(ordersByAmount);
                break;
            default:
                Console.WriteLine("无效的查询方式，请重新选择。");
                break;
        }
    }

    static void PrintOrders(List<Order> orders)
    {
        if (orders.Count == 0)
        {
            Console.WriteLine("未找到符合条件的订单。");
        }
        else
        {
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}