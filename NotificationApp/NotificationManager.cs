namespace NotificationApp
{
    internal class NotificationManager
    {
        private INotificationService notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void SendNotification(string recipient, string message)
        {
            notificationService.Send(recipient, message);
        }
    }
}