using OpenClosedPrinciple;

#region Correct
InvoiceWith PInvoice = new ProposedInvoice();
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);

PInvoice = new FinalInvoice();
double FInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);

#endregion Correct



#region Wrong
InvoiceWithout invoiceWithout = new InvoiceWithout();

double PInvoiceAmount1=invoiceWithout.GetInvoiceDiscount(10000,InvoiceType.ProposedInvoice);

double FInvoiceAmount1 = invoiceWithout.GetInvoiceDiscount(10000, InvoiceType.FinalInvoice);

#endregion

Console.ReadKey();