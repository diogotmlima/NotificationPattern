namespace NotificationPattern.Validations
{
    public partial class Contract
    {
        public Contract IsGreaterThan(decimal val, float comparer, string property, string message)
        {
            if ((double)val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterThan(double val, float comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterThan(float val, float comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterThan(int val, float comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(decimal val, float comparer, string property, string message)
        {
            if ((double)val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(double val, float comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(float val, float comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(int val, float comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(decimal val, float comparer, string property, string message)
        {
            if ((double)val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(double val, float comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(float val, float comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(int val, float comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(decimal val, float comparer, string property, string message)
        {
            if ((double)val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(double val, float comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(float val, float comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(int val, float comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(decimal val, float comparer, string property, string message)
        {
            if ((double)val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(double val, float comparer, string property, string message)
        {
            if (val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(float val, float comparer, string property, string message)
        {
            if (val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(int val, float comparer, string property, string message)
        {
            if (val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

      
        public Contract AreNotEquals(decimal val, float comparer, string property, string message)
        {
            if ((double)val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(double val, float comparer, string property, string message)
        {
            if (val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(float val, float comparer, string property, string message)
        {
            if (val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(int val, float comparer, string property, string message)
        {
            if (val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsBetween(float val, float from, float to, string property, string message)
        {
            if (!(val > from && val < to))
                AddRuleNotification(property, message);

            return this;
        }
    }
}
