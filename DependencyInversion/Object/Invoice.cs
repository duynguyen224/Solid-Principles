using DependencyInversion.Interface;
using DependencyInversion.Interface.Implement;

namespace DependencyInversion.Object
{
    public class Invoice
    {
        public Bike Vehicle { get; set; }

        public int Quantity { get; set; }

        private CashService CashService;

        public Invoice(Bike vehicle, int quantity)
        {
            Vehicle = vehicle;
            Quantity = quantity;
            CashService = new();
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

        public void Pay()
        {
            CashService.Pay();
        }
    }

    //public class Invoice
    //{
    //    public Bike Vehicle { get; set; }

    //    public int Quantity { get; set; }

    //    private IPaymentService PaymentService;

    //    public Invoice(Bike vehicle, int quantity, IPaymentService paymentService)
    //    {
    //        Vehicle = vehicle;
    //        Quantity = quantity;
    //        PaymentService = paymentService;
    //    }

    //    public int CalculateTotal()
    //    {
    //        return Vehicle.Price * Quantity;
    //    }

    //    public void PrintInvoice()
    //    {
    //        string text = $""""
    //        == Your Invoice ==
    //        Vehicle: {Vehicle.Name}
    //        Max speed: {Vehicle.MaxSpeed}
    //        Price: {Vehicle.Price}
    //        Quantity: {Quantity}
    //        TOTAL: {CalculateTotal()}
    //        """";

    //        Console.WriteLine(text);
    //    }

    //    public void SaveInvoiceToDB()
    //    {
    //        Console.WriteLine("\nSuccessfully save the new invoice to the database.");
    //    }

    //    public void Pay()
    //    {
    //        PaymentService.Pay();
    //    }
    //}
}
