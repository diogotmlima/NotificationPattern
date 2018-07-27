using System;

namespace NotificationPattern.Validations
{
    public partial class Contract
    {
        public Contract IsGreaterThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(DateTime val, DateTime comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsBetween(DateTime val, DateTime from, DateTime to, string property, string message)
        {
            if (!(val > from && val < to))
                AddRuleNotification(property, message);

            return this;
        }

    }
}
