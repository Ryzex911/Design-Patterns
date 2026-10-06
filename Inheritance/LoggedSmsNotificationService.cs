namespace NotificationApp;

public class LoggedSmsNotificationService : SmsNotificationService
{
    public override void Send(string recipient, string message)
    {
        Console.WriteLine($"LOG: notificatie naar {recipient}");
        base.Send(recipient, message);
    }
}
