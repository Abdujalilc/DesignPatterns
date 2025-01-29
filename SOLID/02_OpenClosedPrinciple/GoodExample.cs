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
            processor.ProcessPayment(payPalPayment);
        }
    }
    public interface IPayment
    {
        void Process();
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
        public void ProcessPayment(IPayment payment) => payment.Process();
    }
}
/*
 Why is this good?
Because you can add new payment methods (e.g., CryptoPayment) without modifying PaymentProcessor.
 */