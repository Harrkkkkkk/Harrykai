using System;
using System.Collections.Generic;
using System.Linq;

// 订单服务类
public class OrderService
{
    private List<Order> orders;
    private Func<Order, Order, int> currentSortComparison;

    public OrderService()
    {
        orders = new List<Order>();
        currentSortComparison = (x, y) => x.OrderId.CompareTo(y.OrderId); // 默认按订单号排序
    }

    // 添加订单
    public void AddOrder(Order order)
    {
        if (orders.Contains(order))
        {
            throw new Exception("订单已存在，不能重复添加。");
        }
        orders.Add(order);
    }

    // 删除订单
    public void DeleteOrder(int orderId)
    {
        var order = orders.FirstOrDefault(o => o.OrderId == orderId);
        if (order == null)
        {
            throw new Exception($"订单号 {orderId} 不存在，删除失败。");
        }
        orders.Remove(order);
    }

    // 修改订单
    public void UpdateOrder(Order newOrder)
    {
        var oldOrder = orders.FirstOrDefault(o => o.OrderId == newOrder.OrderId);
        if (oldOrder == null)
        {
            throw new Exception($"订单号 {newOrder.OrderId} 不存在，修改失败。");
        }
        int index = orders.IndexOf(oldOrder);
        orders[index] = newOrder;
    }

    // 根据订单号查询订单
    public List<Order> QueryByOrderId(int orderId)
    {
        return orders.Where(o => o.OrderId == orderId).OrderBy(o => o.TotalAmount).ToList();
    }

    // 根据商品名称查询订单
    public List<Order> QueryByProductName(string productName)
    {
        return orders.Where(o => o.OrderDetails.Any(d => d.ProductName == productName)).OrderBy(o => o.TotalAmount).ToList();
    }

    // 根据客户查询订单
    public List<Order> QueryByCustomer(string customer)
    {
        return orders.Where(o => o.Customer == customer).OrderBy(o => o.TotalAmount).ToList();
    }

    // 根据订单金额查询订单
    public List<Order> QueryByTotalAmount(double amount)
    {
        return orders.Where(o => o.TotalAmount == amount).OrderBy(o => o.TotalAmount).ToList();
    }

    // 默认按订单号排序
    public void SortOrders()
    {
        currentSortComparison = (x, y) => x.OrderId.CompareTo(y.OrderId);
        orders = orders.OrderBy(o => o.OrderId).ToList();
    }

    // 自定义排序
    public void SortOrders(Func<Order, Order, int> comparison)
    {
        currentSortComparison = comparison;
        orders.Sort((x, y) => comparison(x, y));
    }

    // 显示所有订单
    public List<Order> GetAllOrders()
    {
        return orders.OrderBy(o => o, Comparer<Order>.Create((x, y) => currentSortComparison(x, y))).ToList();
    }
}