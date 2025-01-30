using System;
class OrderFacade
{
    private Payment _payment = new Payment();
    private Shipping _shipping = new Shipping();

    public void PlaceOrder()
    {
        _payment.Process();
        _shipping.Ship();
    }
}
// Subsystems: Complex logic hidden from the client
class Payment
{
    public void Process() => Console.WriteLine("Payment processed.");
}
class Shipping
{
    public void Ship() => Console.WriteLine("Order shipped.");
}
class Program
{
    static void Main()
    {
        OrderFacade order = new OrderFacade();
        order.PlaceOrder(); // Payment processed. Order shipped.
    }
}
