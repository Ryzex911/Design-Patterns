namespace NotificationApp;

internal class Program
{
    static void Main(string[] args)
    {
        const string email = "student@school.nl";
        const string phone = "0612345678";
        const string message = "Je rooster is gewijzigd.";

        // Opdracht 1: de twee gewone services.
        Test("1 - Gewone e-mail", new EmailNotificationService(), email, message);
        Test("1 - Gewone SMS", new SmsNotificationService(), phone, message);

        // Opdrachten 2 en 3: inheritance.
        Test("2 - Logged Email (inheritance)", new LoggedEmailNotificationService(), email, message);
        Test("2 - Logged SMS (inheritance)", new LoggedSmsNotificationService(), phone, message);
        Test("3 - Urgent Email (inheritance)", new UrgentEmailNotificationService(), email, message);
        Test("3 - Urgent SMS (inheritance)", new UrgentSmsNotificationService(), phone, message);

        // Opdracht 6: dezelfde LoggingDecorator voor e-mail en SMS.
        Test("6 - LoggingDecorator + Email",
            new LoggingNotificationDecorator(new EmailNotificationService()), email, message);
        Test("6 - LoggingDecorator + SMS",
            new LoggingNotificationDecorator(new SmsNotificationService()), phone, message);

        // Opdracht 7: urgent zonder de bestaande services aan te passen.
        Test("7 - UrgentDecorator + Email",
            new UrgentNotificationDecorator(new EmailNotificationService()), email, message);
        Test("7 - UrgentDecorator + SMS",
            new UrgentNotificationDecorator(new SmsNotificationService()), phone, message);

        // Opdrachten 8 en 9: twee volgordes van dezelfde decorators.
        Test("9 - Variant A: Logging -> Urgent -> Email",
            new LoggingNotificationDecorator(
                new UrgentNotificationDecorator(
                    new EmailNotificationService())), email, message);

        Test("9 - Variant B: Urgent -> Logging -> Email",
            new UrgentNotificationDecorator(
                new LoggingNotificationDecorator(
                    new EmailNotificationService())), email, message);

        // Opdracht 10: Logging -> Timestamp -> Urgent -> Email, daarna SMS.
        Test("10 - Logging -> Timestamp -> Urgent -> Email",
            new LoggingNotificationDecorator(
                new TimestampNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new EmailNotificationService()))), email, message);

        Test("10 - Logging -> Timestamp -> Urgent -> SMS",
            new LoggingNotificationDecorator(
                new TimestampNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new SmsNotificationService()))), phone, message);

        // Eindopdracht: SMS + urgent + timestamp + logging.
        INotificationService eindOpdracht =
            new LoggingNotificationDecorator(
                new TimestampNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new SmsNotificationService())));

        Test("EINDOPDRACHT: Logging -> Timestamp -> Urgent -> SMS",
            eindOpdracht, phone, "Je leslokaal is gewijzigd.");

        Console.WriteLine("Klaar. Druk op Enter om af te sluiten.");
        Console.ReadLine();
    }

    private static void Test(string title, INotificationService service,
        string recipient, string message)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(title);
        Console.WriteLine("----------------------------------------");
        service.Send(recipient, message);
    }
}
