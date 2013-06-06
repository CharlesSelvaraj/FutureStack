namespace FutureStack.DomainModel
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public class Transaction
    {
        public String Id { get; protected set; }
        public List<AddOn> AddOns { get; protected set; }
        public Decimal? Amount { get; protected set; }
        public String AvsErrorResponseCode { get; protected set; }
        public String AvsPostalCodeResponseCode { get; protected set; }
        public String AvsStreetAddressResponseCode { get; protected set; }
        public Address BillingAddress { get; protected set; }
        public String Channel { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public CreditCard CreditCard { get; protected set; }
        public String CurrencyIsoCode { get; protected set; }
        public Customer Customer { get; protected set; }
        public String CvvResponseCode { get; protected set; }
        public Descriptor Descriptor { get; protected set; }
        public List<Discount> Discounts { get; protected set; }
        public TransactionGatewayRejectionReason GatewayRejectionReason { get; protected set; }
        public String MerchantAccountId { get; protected set; }
        public String OrderId { get; protected set; }
        public String PlanId { get; protected set; }
        public String ProcessorAuthorizationCode { get; protected set; }
        public String ProcessorResponseCode { get; protected set; }
        public String ProcessorResponseText { get; protected set; }
        public String PurchaseOrderNumber { get; protected set; }
        public Boolean? Recurring { get; protected set; }
        public String RefundedTransactionId { get; protected set; }

        [Obsolete("Use Transaction.RefundIds")]
        public String RefundId { get; protected set; }

        public List<String> RefundIds { get; protected set; }
        public String SettlementBatchId { get; protected set; }
        public Address ShippingAddress { get; protected set; }
        public TransactionStatus Status { get; protected set; }
        public StatusEvent[] StatusHistory { get; protected set; }
        public String SubscriptionId { get; protected set; }
        public Subscription Subscription { get; protected set; }
        public Decimal? TaxAmount { get; protected set; }
        public Boolean? TaxExempt { get; protected set; }
        public TransactionType Type { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
        public Dictionary<String, String> CustomFields { get; protected set; }
        public DisbursementDetails DisbursementDetails { get; protected set; }
    }
}