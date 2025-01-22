using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP06
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
