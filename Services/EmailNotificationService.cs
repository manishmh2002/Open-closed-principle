using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = EmailNotificationService.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Handles sending of email notifications. Implements the
 *               INotificationService interface to provide specific behavior
 *               for email notifications.
 *****************************************************************************/


namespace Open_closed_principle.Models
{
    /// <summary>
    /// Provides functionality to send email notifications.
    /// Implements the <see cref="INotificationService"/> interface.
    /// </summary>
    public class EmailNotificationService : INotificationService
    {
        /// <summary>
        /// Sends an email notification.
        /// </summary>
        /// <param name="notification">The notification to send.</param>
        public void Send(Notification notification)
        {
            if (notification == null)
            {
                throw new ArgumentNullException(nameof(notification), "Notification cannot be null.");
            }

            if (notification.Type != NotificationType.Email)
            {
                throw new ArgumentException("Notification type must be Email.", nameof(notification));
            }

            // Simulate sending an email
            Console.WriteLine($"Sending Email: {notification.Message}");
        }
    }
}