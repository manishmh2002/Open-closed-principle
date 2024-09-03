using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = NotificationType.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Defines the different types of notifications that the system
 *               can handle.
 *****************************************************************************/

namespace Open_closed_principle.Models
{
    /// <summary>
    /// Defines the types of notifications in the system.
    /// </summary>
    public enum NotificationType
    {
        /// <summary>
        /// Represents an email notification.
        /// </summary>
        Email,

        /// <summary>
        /// Represents an SMS notification.
        /// </summary>
        SMS,

        /// <summary>
        /// Represents a push notification.
        /// </summary>
        Push
    }
}
