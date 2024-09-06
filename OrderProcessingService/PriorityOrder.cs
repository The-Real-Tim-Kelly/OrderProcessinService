public class PriorityOrder : Order
{
    public PriorityOrder()
    {
        OrderType = "Priority";
    }

    public override void Process()
    {
        Console.WriteLine("Processing Priority Order.");
    }
}