using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question03
{
    class PushNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine("**************** Push Notification Service *******************");
            Console.WriteLine("From : Abdelrahman Gamgom");
            Console.WriteLine($"To : {Recipient}");
            Console.WriteLine(Message);
        }
    }
}
