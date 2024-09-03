using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = NotificationContext.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Provides a context for managing notifications, including 
 *               validation and processing of different notification types.
 *****************************************************************************/

namespace Open_closed_principle.Models
{
    /// <summary>
    /// Provides context for managing notifications, including validation and
    /// processing of different notification types.
    /// </summary>
    public class NotificationContext
    {
        /// <summary>
        /// A function to determine if a given notification is valid.
        /// </summary>
        public Func<Notification, bool> IsNotificationValid { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationContext"/> class
        /// with default validation functions.
        /// </summary>
        public NotificationContext()
        {
            // Default validation function to check if the notification message is not empty
            IsNotificationValid = notification => !string.IsNullOrEmpty(notification.Message);
        }

        /// <summary>
        /// Processes the given list of notifications based on their types and validity.
        /// </summary>
        /// <param name="notifications">The list of notifications to process.</param>
        /// <returns>A list of error messages for invalid notifications.</returns>
        public List<string> ProcessNotifications(IEnumerable<Notification> notifications)
        {
            var errors = new List<string>();

            foreach (var notification in notifications)
            {
                if (!IsNotificationValid(notification))
                {
                    errors.Add($"Notification of type '{notification.Type}' is invalid due to empty message.");
                }
                else
                {
                    notification.Display(); // Display the notification
                }
            }

            return errors;
        }
    }
}

