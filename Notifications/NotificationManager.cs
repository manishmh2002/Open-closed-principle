using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = NotificationManager.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Manages the creation and storage of notifications. Provides
 *               methods to add, remove, and retrieve notifications.
 *****************************************************************************/

namespace Open_closed_principle.Models
{
    /// <summary>
    /// Manages the creation and storage of notifications.
    /// Provides methods to add, remove, and retrieve notifications.
    /// </summary>
    public class NotificationManager
    {
        private readonly List<Notification> _notifications;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationManager"/> class.
        /// </summary>
        public NotificationManager()
        {
            _notifications = new List<Notification>();
        }

        /// <summary>
        /// Adds a notification to the manager.
        /// </summary>
        /// <param name="notification">The notification to add.</param>
        public void AddNotification(Notification notification)
        {
            if (notification == null)
            {
                throw new ArgumentNullException(nameof(notification), "Notification cannot be null.");
            }

            _notifications.Add(notification);
        }

        /// <summary>
        /// Removes a notification from the manager.
        /// </summary>
        /// <param name="notification">The notification to remove.</param>
        public void RemoveNotification(Notification notification)
        {
            if (notification == null)
            {
                throw new ArgumentNullException(nameof(notification), "Notification cannot be null.");
            }

            _notifications.Remove(notification);
        }

        /// <summary>
        /// Retrieves all notifications managed by this manager.
        /// </summary>
        /// <returns>A list of notifications.</returns>
        public List<Notification> GetNotifications()
        {
            return _notifications.ToList();
        }

        /// <summary>
        /// Retrieves notifications by type.
        /// </summary>
        /// <param name="type">The type of notifications to retrieve.</param>
        /// <returns>A list of notifications of the specified type.</returns>
        public List<Notification> GetNotificationsByType(NotificationType type)
        {
            return _notifications.Where(n => n.Type == type).ToList();
        }
    }
}
