namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();

            invoice.AddInvoice();
            invoice.DeleteInvoice();
        }
    }
}
