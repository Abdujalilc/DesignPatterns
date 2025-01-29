public class PaymentProcessorBad
{
    public void ProcessPayment(string type)
    {
        if (type == "CreditCard")
            Console.WriteLine("Processing credit card payment");
        else if (type == "PayPal")
            Console.WriteLine("Processing PayPal payment");
    }
}
