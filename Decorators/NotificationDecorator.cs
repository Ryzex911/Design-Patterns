namespace NotificationApp;

public abstract class NotificationDecorator : INotificationService
{
    protected readonly INotificationService notificationService;

    protected NotificationDecorator(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public abstract void Send(string recipient, string message);
}
