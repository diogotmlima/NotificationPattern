namespace NotificationPattern.Validations
{
    public partial class Contract
    {
        public Contract IsGreaterThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterThan(double val, double comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterThan(float val, double comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterThan(int val, double comparer, string property, string message)
        {
            if (val <= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(double val, double comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(float val, double comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(int val, double comparer, string property, string message)
        {
            if (val < comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(double val, double comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(float val, double comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(int val, double comparer, string property, string message)
        {
            if (val >= comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(double val, double comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(float val, double comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(int val, double comparer, string property, string message)
        {
            if (val > comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(decimal val, double comparer, string property, string message)
        {
            if ((double)val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(double val, double comparer, string property, string message)
        {
            if (val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(float val, double comparer, string property, string message)
        {
            if (val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreEquals(int val, double comparer, string property, string message)
        {
            if (val != comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(decimal val, double comparer, string property, string message)
        {
            if ((double)val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(double val, double comparer, string property, string message)
        {
            if (val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(float val, double comparer, string property, string message)
        {
            if (val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(int val, double comparer, string property, string message)
        {
            if (val == comparer)
                AddRuleNotification(property, message);

            return this;
        }

        public Contract IsBetween(double val, double from, double to, string property, string message)
        {
            if (!(val > from && val < to))
                AddRuleNotification(property, message);

            return this;
        }        
    }
}