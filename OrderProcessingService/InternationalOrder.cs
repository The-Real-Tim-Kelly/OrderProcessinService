public class InternationalOrder : Order
{
    public InternationalOrder()
    {
        OrderType = "International";
    }

    public override void Process()
    {
        Console.WriteLine("Processing International Order.");
    }
}