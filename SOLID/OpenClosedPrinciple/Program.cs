using OpenClosedPrinciple;

#region Correct
InvoiceWith FInvoice = new FinalInvoice();
InvoiceWith PInvoice = new ProposedInvoice();
InvoiceWith RInvoice = new RecurringInvoice();

double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
#endregion Correct

#region Wrong
InvoiceWithout invoiceWithout = new InvoiceWithout();
invoiceWithout.GetInvoiceDiscount(10000,InvoiceType.ProposedInvoice);
#endregion

Console.ReadKey();