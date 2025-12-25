using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal class Notifier:INotifier
    {
        public string SmtpServer { get; }
        public int Port { get; }
        public string SenderAddress { get; }
        public string SenderPassword { get; }

        public Notifier(string smptServer,int port, string senderAddress, string senderPassword)
        {
            SmtpServer=smptServer;
            Port = port;
            SenderAddress=senderAddress;
            SenderPassword=senderPassword;
        }

        public void Notify(string email, string subject, string body)
        { 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've a new email form '{SenderAddress}' with subject '{subject}'");
            Console.WriteLine(body);
            Console.WriteLine($"Message sent successfully to '{email}'");
            Console.WriteLine("*************************");
            Console.ForegroundColor= ConsoleColor.White;
        }

    }
}
