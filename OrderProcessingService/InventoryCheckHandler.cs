public class InventoryCheckHandler : OrderHandler
{
    public override void Handle(Order order)
    {
        Console.WriteLine("Checking inventory for order.");
        // Logic for inventory check
        if (_nextHandler != null)
            _nextHandler.Handle(order);
    }
}