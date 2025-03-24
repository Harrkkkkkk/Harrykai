using System;
using System.Collections.Generic;

// 订单明细类
public class OrderDetails
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public OrderDetails(int id, string productName, double price, int quantity)
    {
        Id = id;
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }

    public override bool Equals(object obj)
    {
        return obj is OrderDetails details &&
               Id == details.Id &&
               ProductName == details.ProductName &&
               Price == details.Price &&
               Quantity == details.Quantity;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, ProductName, Price, Quantity);
    }

    public override string ToString()
    {
        return $"Id: {Id}, ProductName: {ProductName}, Price: {Price}, Quantity: {Quantity}";
    }
}

// 订单类
public class Order
{
    public int OrderId { get; set; }
    public string Customer { get; set; }
    public List<OrderDetails> OrderDetails { get; set; }

    public double TotalAmount
    {
        get
        {
            return OrderDetails.Sum(d => d.Price * d.Quantity);
        }
    }

    public Order(int orderId, string customer, List<OrderDetails> orderDetails)
    {
        OrderId = orderId;
        Customer = customer;
        OrderDetails = orderDetails;
    }

    public override bool Equals(object obj)
    {
        return obj is Order order &&
               OrderId == order.OrderId &&
               Customer == order.Customer &&
               OrderDetails.SequenceEqual(order.OrderDetails);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(OrderId, Customer, OrderDetails);
    }

    public override string ToString()
    {
        string details = string.Join("\n  ", OrderDetails.Select(d => d.ToString()));
        return $"OrderId: {OrderId}, Customer: {Customer}, TotalAmount: {TotalAmount}\n  {details}";
    }
}