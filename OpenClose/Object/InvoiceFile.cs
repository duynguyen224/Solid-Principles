using OpenClose.Interface;
using SingleResponsibility.Object;

namespace OpenClose.Object
{
    public class InvoiceFile : IInvoice
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("\nSuccessfully save the new invoice to the file.");
        }
    }
}
