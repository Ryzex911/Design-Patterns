using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApp
{
    internal class WhatsAppAdapter : INotificationService
    {
        private ExternalWhatsAppLibrary.WhatsAppClient whatsAppClient;

        public WhatsAppAdapter(ExternalWhatsAppLibrary.WhatsAppClient whatsAppClient)
        {
            this.whatsAppClient = whatsAppClient;
        }

        public void Send(string recipient, string message)
        {
            whatsAppClient.SendWhatsAppMessage(recipient, message, false);
        }
    }
}
