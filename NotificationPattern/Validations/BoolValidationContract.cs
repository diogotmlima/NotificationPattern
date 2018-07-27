namespace NotificationPattern.Validations
{
     public partial class Contract
    {
        
        public Contract IsTrue(bool val, string property, string message)
        {
            if (!val)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsFalse(bool val, string property, string message)
        {
            if (val)
                AddRuleNotification(property, message);

            return this;
        }
    }
}