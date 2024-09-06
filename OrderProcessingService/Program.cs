class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create the Order
        Order order = OrderFactory.CreateOrder("priority");
        order.ShippingAddress = "1234 Main St, City, Country";

        // Step 2: Set Shipping Strategy
        order.ShippingStrategy = new ExpeditedShipping();

        // Step 3: Create the Chain of Responsibility
        OrderHandler inventoryCheck = new InventoryCheckHandler();
        OrderHandler paymentProcessing = new PaymentProcessingHandler();
        OrderHandler fraudDetection = new FraudDetectionHandler();

        // Set the chain
        inventoryCheck.SetNextHandler(paymentProcessing);
        paymentProcessing.SetNextHandler(fraudDetection);

        // Step 4: Process the order
        order.Process(); // Handle order-specific logic
        inventoryCheck.Handle(order); // Chain of Responsibility handling
        order.ShippingStrategy.Ship(order); // Shipping Strategy handling

        Console.WriteLine("Order processing complete.");
    }
}