using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question03
{
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine("**************** SMS Notification *******************");
            Console.WriteLine("From : Abdelrahman Gamgom");
            Console.WriteLine($"To : {Recipient}");
            Console.WriteLine("   "+ Message);
        }

       
    }
}
