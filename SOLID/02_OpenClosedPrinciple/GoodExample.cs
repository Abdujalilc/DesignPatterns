namespace OCP.GoodExample
{
    class Program
    {
        static void Main()
        {
            PaymentProcessor processor = new PaymentProcessor();

            IPayment creditCardPayment = new CreditCardPayment();
            IPayment payPalPayment = new PayPalPayment();

            processor.ProcessPayment(creditCardPayment);
            processor.ProcessPayment(payPalPayment); // New payment methods can be added without modifying PaymentProcessor
        }
    }
    public interface IPayment
    {
        void Process(); // Defines a contract for all payment methods
    }
    public class CreditCardPayment : IPayment
    {
        public void Process() => Console.WriteLine("Processing credit card payment");
    }
    public class PayPalPayment : IPayment
    {
        public void Process() => Console.WriteLine("Processing PayPal payment");
    }
    public class PaymentProcessor
    {
        public void ProcessPayment(IPayment payment) => payment.Process(); // Uses abstraction to allow extension
    }
}
/*
 * Why is this good?
 * ✅ Follows OCP → You can add new payment methods (e.g., CryptoPayment) without modifying PaymentProcessor.
 */
