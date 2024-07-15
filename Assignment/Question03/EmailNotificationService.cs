using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question03
{
    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine("**************** Email Notification *******************");
            Console.WriteLine("From : Abdelrahman Gamgom");
            Console.WriteLine($"To : {Recipient}");
            Console.WriteLine(Message);
        }
    }
}
