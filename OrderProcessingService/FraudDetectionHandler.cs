public class FraudDetectionHandler : OrderHandler
{
    public override void Handle(Order order)
    {
        Console.WriteLine("Checking for fraud.");
        // Logic for fraud detection
        if (_nextHandler != null)
            _nextHandler.Handle(order);
    }
}