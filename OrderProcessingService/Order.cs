public abstract class Order
{
    public string OrderType { get; protected set; }
    public string ShippingAddress { get; set; }
    public IShippingStrategy ShippingStrategy { get; set; }

    public abstract void Process();
}