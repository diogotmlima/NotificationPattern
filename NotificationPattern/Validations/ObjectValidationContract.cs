namespace NotificationPattern.Validations
{
    public partial class Contract
    {
        public Contract IsNull(object obj, string property, string message)
        {
            if (obj != null)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsNotNull(object obj, string property, string message)
        {
            if (obj == null)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(object obj, object comparer, string property, string message)
        {
            if (obj != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(object obj, object comparer, string property, string message)
        {
            if (obj == comparer)
                AddRuleNotification(property, message);

            return this;
        }
    }
}