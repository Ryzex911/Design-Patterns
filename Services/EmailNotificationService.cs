namespace NotificationApp;

public class EmailNotificationService : INotificationService
{
    // Virtual maakt de eerste inheritance-oefeningen mogelijk.
    public virtual void Send(string recipient, string message)
    {
        Console.WriteLine("EMAIL");
        Console.WriteLine($"Aan: {recipient}");
        Console.WriteLine($"Bericht: {message}");
        Console.WriteLine();
    }
}
