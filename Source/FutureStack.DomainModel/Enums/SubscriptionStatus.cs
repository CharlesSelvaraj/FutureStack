namespace FutureStack.DomainModel.Enums
{
    using System;
    using FutureStack.DomainModel;

    /// <summary>
    /// The possible statuses for <see cref="Subscription"/>
    /// </summary>
    public class SubscriptionStatus : Enumeration
    {
        /// <summary>
        /// Indicates that the <see cref="Subscription"/> is currently active and in good standing
        /// </summary>
        public static readonly SubscriptionStatus ACTIVE = new SubscriptionStatus("Active");
        /// <summary>
        /// Indicates that the <see cref="Subscription"/> has been canceled and will not be billed
        /// </summary>
        public static readonly SubscriptionStatus CANCELED = new SubscriptionStatus("Canceled");
        /// <summary>
        /// Indicates that the <see cref="Subscription"/> has reached the end of the specified billing cycles
        /// </summary>
        public static readonly SubscriptionStatus EXPIRED = new SubscriptionStatus("Expired");
        /// <summary>
        /// Indicates that the <see cref="Subscription"/> is currently active but past due
        /// </summary>
        public static readonly SubscriptionStatus PAST_DUE = new SubscriptionStatus("Past Due");
        /// <summary>
        /// Indicates that the <see cref="Subscription"/> is currently pending
        /// </summary>
        public static readonly SubscriptionStatus PENDING = new SubscriptionStatus("Pending");
        /// <summary>
        /// A placeholder for unrecognized subscription statuses, implemented for future compatibility
        /// </summary>
        public static readonly SubscriptionStatus UNRECOGNIZED = new SubscriptionStatus("Unrecognized");

        public static readonly SubscriptionStatus[] STATUSES = { ACTIVE, CANCELED, EXPIRED, PAST_DUE, PENDING };

        protected SubscriptionStatus(String name) : base(name) { }
    }
}