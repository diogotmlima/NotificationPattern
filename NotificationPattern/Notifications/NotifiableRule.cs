using System.Collections.Generic;
using System.Linq;

namespace NotificationPattern.Notifications
{
   public abstract class NotifiableRule
    {
        private readonly List<Notification> _notifications;

        protected NotifiableRule() => _notifications = new List<Notification>();

        public IReadOnlyCollection<Notification> Notifications { get { return _notifications; } }

        public void AddRuleNotification(string property, string message)
        {
            _notifications.Add(new Notification(property, message));
        }

        public void AddRuleNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddRuleNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddRuleNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddRuleNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddRuleNotifications(NotifiableRule item)
        {
            AddRuleNotifications(item.Notifications);
        }

        public void AddRuleNotifications(params NotifiableRule[] items)
        {
            foreach (var item in items)
                AddRuleNotifications(item);
        }

        public bool Invalid => _notifications.Any();
        public bool Valid => !Invalid;
    }
}