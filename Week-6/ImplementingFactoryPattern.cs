using System;

namespace FactoryPatternDemo
{
    // Interface
    public interface INotification
    {
        void Send(string message);
    }

    // Concrete Classes
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS Sent: " + message);
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Push Notification Sent: " + message);
        }
    }

    // Factory Class
    public class NotificationFactory
    {
        public INotification CreateNotification(string type)
        {
            switch (type.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }

    // Client
    class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory factory = new NotificationFactory();

            INotification notification = factory.CreateNotification("email");

            notification.Send("Welcome to our service!");

            Console.ReadLine();
        }
    }
}