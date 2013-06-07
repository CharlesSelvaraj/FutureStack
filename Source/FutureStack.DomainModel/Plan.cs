namespace FutureStack.DomainModel
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public class Plan
    {
        public List<AddOn> AddOns { get; protected set; }
        public Int32? BillingDayOfMonth { get; protected set; }
        public Int32? BillingFrequency { get; protected set; }
        public String CurrencyIsoCode { get; protected set; }
        public String Description { get; protected set; }
        public List<Discount> Discounts { get; protected set; }
        public String Id { get; protected set; }
        public String Name { get; protected set; }
        public Int32? NumberOfBillingCycles { get; protected set; }
        public Decimal? Price { get; protected set; }
        public Boolean? TrialPeriod { get; protected set; }
        public Int32? TrialDuration { get; protected set; }
        public PlanDurationUnit TrialDurationUnit { get; protected set; }
    }
}