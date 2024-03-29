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
    }
}
