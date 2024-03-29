namespace SingleResponsibility.Object
{
    public class InvoicePersistence
    {
        public Invoice Invoice { get; set; }

        public InvoicePersistence(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void SaveInvoiceToDB()
        {
            Console.WriteLine("\nSuccessfully save the new invoice to the database.");
        }
    }
}
