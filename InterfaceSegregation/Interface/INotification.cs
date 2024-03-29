using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Interface
{
    public interface INotification
    {
        public void SendMail();
        public void SendSms();
    }
}
