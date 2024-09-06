public class PaymentProcessingHandler : OrderHandler
{
    public override void Handle(Order order)
    {
        Console.WriteLine("Processing payment for order.");
        // Logic for payment processing
        if (_nextHandler != null)
            _nextHandler.Handle(order);
    }
}