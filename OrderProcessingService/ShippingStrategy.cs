// Shipping strategy interface
public interface IShippingStrategy
{
    void Ship(Order order);
}

// Concrete Shipping strategies
public class StandardShipping : IShippingStrategy
{
    public void Ship(Order order)
    {
        Console.WriteLine("Shipping via Standard Shipping.");
    }
}

public class ExpeditedShipping : IShippingStrategy
{
    public void Ship(Order order)
    {
        Console.WriteLine("Shipping via Expedited Shipping.");
    }
}

public class InternationalShipping : IShippingStrategy
{
    public void Ship(Order order)
    {
        Console.WriteLine("Shipping via International Shipping.");
    }
}