namespace DependencyInversion.Interface.Implement
{
    public class BankingService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine("You pay the invoice by banking");
        }
    }
}
