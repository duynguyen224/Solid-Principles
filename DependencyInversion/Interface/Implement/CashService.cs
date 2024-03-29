namespace DependencyInversion.Interface.Implement
{
    public class CashService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine("You pay the invoice by cash");
        }
    }
}
