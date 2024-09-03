using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = SmsNotificationService.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Implements the INotificationService interface for sending
 *               SMS notifications.
 *****************************************************************************/


namespace Open_closed_principle.Models
{
    /// <summary>
    /// Provides functionality to send SMS notifications.
    /// </summary>
    public class SmsNotificationService : INotificationService
    {
        /// <summary>
        /// Sends an SMS notification.
        /// </summary>
        /// <param name="notification">The notification to send.</param>
        public void Send(Notification notification)
        {
            if (notification.Type != NotificationType.SMS)
            {
                throw new ArgumentException("Notification type must be SMS for SmsNotificationService.");
            }

            // Simulate sending an SMS notification
            Console.WriteLine($"Sending SMS Notification: {notification.Message}");
        }
    }
}
