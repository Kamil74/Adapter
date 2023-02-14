namespace Adapter;

public class SmsSender
{
    public void SmsSend(string to, string text)
    {
        Console.WriteLine($"Sending SMS to : {to}");
    }

    
}