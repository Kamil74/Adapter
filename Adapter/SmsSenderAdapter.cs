namespace Adapter;

public class SmsSenderAdapter : INotificationSender
{
    private  SmsSender _smsSender = new SmsSender();
    public void SendNotification(int userId, Notification notification)
    {
        string userPhoneNumber = null; // based on userId
        _smsSender.SmsSend(userPhoneNumber, $"{notification.Title} {notification.Body}");
    }
}