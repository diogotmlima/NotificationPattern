using NotificationPattern.Notifications;

namespace NotificationPattern.Validations
{
    public partial class Contract : NotifiableRule
    {
        public Contract Requires()
        {
            return this;
        }

        public Contract Join(params NotifiableRule[] items)
        {
            if (items != null)
            {
                foreach (var notifiableRule in items)
                {
                    if (notifiableRule.Invalid)
                        AddRuleNotifications(notifiableRule.Notifications);
                }
            }

            return this;
        }
    }
}

