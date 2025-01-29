namespace OCP.BadExample
{
    class Program
    {
        static void Main()
        {
            PaymentProcessorBad processor = new PaymentProcessorBad();
            processor.ProcessPayment("CreditCard");
            processor.ProcessPayment("PayPal");
        }
    }

    public class PaymentProcessorBad
    {
        public void ProcessPayment(string type)
        {
            if (type == "CreditCard")
                Console.WriteLine("Processing credit card payment");
            else if (type == "PayPal")
                Console.WriteLine("Processing PayPal payment");
            // ❌ Violates OCP: Adding a new payment method requires modifying this method
        }
    }
}

/*
 * Why is this bad?
 * ❌ Violates OCP → If you add a new payment method, you must modify ProcessPayment, breaking existing code.
 */
