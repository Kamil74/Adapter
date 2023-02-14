// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("Hello, World!");
INotificationSender notificationSender = new SmsSenderAdapter();
notificationSender.SendNotification(1, new Notification(){ Title = "Text", Body = "Body"});