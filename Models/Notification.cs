using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = Notification.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Represents a notification with a type and message. It provides
 *               methods to create and manage notifications.
 *****************************************************************************/


namespace Open_closed_principle.Models
{
    /// <summary>
    /// Represents a notification in the system.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        public NotificationType Type { get; set; }

        /// <summary>
        /// Gets or sets the message of the notification.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        /// <param name="type">The type of the notification.</param>
        /// <param name="message">The message of the notification.</param>
        public Notification(NotificationType type, string message)
        {
            Type = type;
            Message = message;
        }

        /// <summary>
        /// Displays the notification based on its type.
        /// </summary>
        public void Display()
        {
            switch (Type)
            {
                case NotificationType.Email:
                    Console.WriteLine($"Email Notification: {Message}");
                    break;
                case NotificationType.SMS:
                    Console.WriteLine($"SMS Notification: {Message}");
                    break;
                case NotificationType.Push:
                    Console.WriteLine($"Push Notification: {Message}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}