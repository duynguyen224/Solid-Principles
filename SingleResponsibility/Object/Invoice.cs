namespace SingleResponsibility.Object
{
    public class Invoice
    {
        public Bike Vehicle { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Invoice(Bike vehicle, int quantity, DateTime purchaseDate)
        {
            Vehicle = vehicle;
            Quantity = quantity;
            PurchaseDate = purchaseDate;
        }

        public int CalculateTotal()
        {
            return Vehicle.Price * Quantity;
        }

        public void PrintInvoice()
        {
            string text = $""""
            == Your Invoice ==
            Vehicle: {Vehicle.Name}
            Max speed: {Vehicle.MaxSpeed}
            Price: {Vehicle.Price}
            Quantity: {Quantity}
            TOTAL: {CalculateTotal()}
            """";

            Console.WriteLine(text);
        }

        public void SaveInvoiceToDB()
        {
            Console.WriteLine("\nSuccessfully save the new invoice to the database.");
        }
    }
}
