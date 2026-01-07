namespace OPP.Enums;

public enum OrderStatus
{
    Placed,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

public class Order
{
    public int OrderId { get; set; }
    public OrderStatus CurrentStatus { get; set; }
}