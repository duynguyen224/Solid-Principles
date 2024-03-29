namespace SingleResponsibility.Object
{
    public class InvoicePrinter
    {
        public Invoice Invoice { get; set; }

        public InvoicePrinter(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void PrintInvoice()
        {
            string text = $""""
            == Your Invoice ==
            Vehicle: {Invoice.Vehicle.Name}
            Max speed: {Invoice.Vehicle.MaxSpeed}
            Price: {Invoice.Vehicle.Price}
            Quantity: {Invoice.Quantity}
            Purchase date: {Invoice.PurchaseDate}
            TOTAL: {Invoice.Vehicle.Price * Invoice.Quantity}
            """";

            Console.WriteLine(text);
        }
    }
}
