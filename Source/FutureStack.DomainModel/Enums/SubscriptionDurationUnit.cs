namespace FutureStack.DomainModel.Enums
{
    using System;

    public class SubscriptionDurationUnit : Enumeration
    {
        /// <summary>
        /// A duration unit used for subscription periods measured in days
        /// </summary>
        public static readonly SubscriptionDurationUnit DAY = new SubscriptionDurationUnit("day");
        /// <summary>
        /// A duration unit used for subscription periods measured in months
        /// </summary>
        public static readonly SubscriptionDurationUnit MONTH = new SubscriptionDurationUnit("month");
        /// <summary>
        /// A placeholder for unrecognized duration units, implemented for future compatibility
        /// </summary>
        public static readonly SubscriptionDurationUnit UNRECOGNIZED = new SubscriptionDurationUnit("unrecognized");

        public static readonly SubscriptionDurationUnit[] ALL = { DAY, MONTH };

        protected SubscriptionDurationUnit(String name) : base(name) { }
    }
}