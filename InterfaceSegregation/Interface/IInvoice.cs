namespace InterfaceSegregation.Interface
{
    public interface IInvoice
    {
        public void Print();
        public void SaveToDB();
        public void SaveToFile();
        public void UploadToCloud();
        public void SendMail();
        public void SendSms();
    }
}
