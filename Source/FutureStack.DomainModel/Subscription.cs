namespace FutureStack.DomainModel
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public class Subscription
    {
        public Decimal? Balance { get; protected set; }
        public List<AddOn> AddOns { get; protected set; }
        public Int32? BillingDayOfMonth { get; protected set; }
        public DateTime? BillingPeriodEndDate { get; protected set; }
        public DateTime? BillingPeriodStartDate { get; protected set; }
        public Int32? CurrentBillingCycle { get; protected set; }
        public Int32? DaysPastDue { get; protected set; }
        public Descriptor Descriptor { get; protected set; }
        public List<Discount> Discounts { get; protected set; }
        public Int32? FailureCount { get; protected set; }
        public DateTime? FirstBillingDate { get; protected set; }
        public Boolean? HasTrialPeriod { get; protected set; }
        public String Id { get; protected set; }
        public Boolean? NeverExpires { get; protected set; }
        public Decimal? NextBillAmount { get; protected set; }
        public DateTime? NextBillingDate { get; protected set; }
        public Decimal? NextBillingPeriodAmount { get; protected set; }
        public Int32? NumberOfBillingCycles { get; protected set; }
        public DateTime? PaidThroughDate { get; protected set; }
        public String PaymentMethodToken { get; protected set; }
        public String PlanId { get; protected set; }
        public Decimal? Price { get; protected set; }
        public SubscriptionStatus Status { get; protected set; }
        public List<Transaction> Transactions { get; protected set; }
        public Int32? TrialDuration { get; protected set; }
        public SubscriptionDurationUnit TrialDurationUnit { get; protected set; }
        public String MerchantAccountId { get; protected set; }
    }
}