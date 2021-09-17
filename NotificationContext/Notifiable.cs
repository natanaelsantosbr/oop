using System.Collections.Generic;

namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            this.Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }

        public void Add(Notification notification)
        {
            this.Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<Notification> notifications)
        {
            this.Notifications.AddRange(notifications);
        }
    }
}