using System.Collections.Generic;
using System.Linq;

namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            this.Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {
            this.Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            this.Notifications.AddRange(notifications);
        }

        public bool IsValid => this.Notifications.Any();
    }
}