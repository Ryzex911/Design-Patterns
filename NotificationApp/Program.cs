using ExternalWhatsAppLibrary;

namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Email
            NotificationManager emailManager =
                new NotificationManager(
                    new EmailNotificationService()
                );

            emailManager.SendNotification(
                "student@school.nl",
                "Je nieuwe rooster staat klaar."
            );


            // SMS
            NotificationManager smsManager =
                new NotificationManager(
                    new SmsNotificationService()
                );

            smsManager.SendNotification(
                "0612345678",
                "Je les begint over 15 minuten."
            );


            // Push
            NotificationManager pushManager =
                new NotificationManager(
                    new PushNotificationService()
                );

            pushManager.SendNotification(
                "student123",
                "Er staat nieuwe feedback voor je klaar."
            );


            // WhatsApp via Adapter
            WhatsAppClient whatsAppClient =
                new WhatsAppClient();

            WhatsAppAdapter whatsAppAdapter =
                new WhatsAppAdapter(whatsAppClient);

            NotificationManager whatsAppManager =
                new NotificationManager(whatsAppAdapter);

            whatsAppManager.SendNotification(
                "0612345678",
                "Dit bericht wordt verstuurd via WhatsApp."
            );


            Console.ReadLine();
        }
    }
}