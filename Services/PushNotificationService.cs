using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = PushNotificationService.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Implements the INotificationService interface for sending
 *               push notifications.
 *****************************************************************************/


namespace Open_closed_principle.Models
{
    /// <summary>
    /// Provides functionality to send push notifications.
    /// </summary>
    public class PushNotificationService : INotificationService
    {
        /// <summary>
        /// Sends a push notification.
        /// </summary>
        /// <param name="notification">The notification to send.</param>
        public void Send(Notification notification)
        {
            if (notification.Type != NotificationType.Push)
            {
                throw new ArgumentException("Notification type must be Push for PushNotificationService.");
            }

            // Simulate sending a push notification
            Console.WriteLine($"Sending Push Notification: {notification.Message}");
        }
    }
}

