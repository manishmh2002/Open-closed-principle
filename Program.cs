using System;
using Open_closed_principle.Models;

namespace Open_closed_principle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create instances of different notification services
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            // Create a notification
            var notification = new Notification(NotificationType.Email, "Your email notification message!");

            // Send notifications using different services
            SendNotification(emailService, notification);
            SendNotification(smsService, notification);
            SendNotification(pushService, notification);
        }

        private static void SendNotification(INotificationService notificationService, Notification notification)
        {
            notificationService.Send(notification);
        }
    }
}
