public static class OrderFactory
{
    public static Order CreateOrder(string orderType)
    {
        switch (orderType.ToLower())
        {
            case "standard":
                return new StandardOrder();
            case "priority":
                return new PriorityOrder();
            case "international":
                return new InternationalOrder();
            default:
                throw new ArgumentException("Invalid order type.");
        }
    }
}