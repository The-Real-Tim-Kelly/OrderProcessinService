public abstract class OrderHandler
{
    protected OrderHandler _nextHandler;

    public void SetNextHandler(OrderHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void Handle(Order order);
}