public class StandardOrder : Order
{
    public StandardOrder()
    {
        OrderType = "Standard";
    }

    public override void Process()
    {
        Console.WriteLine("Processing Standard Order.");
    }
}