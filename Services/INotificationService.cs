using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * Filename    = INotificationService.cs
 *
 * Author      = Manish M H
 *
 * Product     = NotificationSystem
 * 
 * Project     = Open–closed principle
 *
 * Description = Defines the contract for notification services. 
 *               Any class implementing this interface must provide 
 *               functionality to send notifications.
 *****************************************************************************/


namespace Open_closed_principle.Models
{
    /// <summary>
    /// Defines the contract for notification services.
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Sends a notification.
        /// </summary>
        /// <param name="notification">The notification to send.</param>
        void Send(Notification notification);
    }
}
