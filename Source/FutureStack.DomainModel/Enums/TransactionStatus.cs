namespace FutureStack.DomainModel.Enums
{
    using System;

    public class TransactionStatus : Enumeration
    {
        public static readonly TransactionStatus AUTHORIZATION_EXPIRED = new TransactionStatus("authorization_expired");
        public static readonly TransactionStatus AUTHORIZED = new TransactionStatus("authorized");
        public static readonly TransactionStatus AUTHORIZING = new TransactionStatus("authorizing");
        public static readonly TransactionStatus FAILED = new TransactionStatus("failed");
        public static readonly TransactionStatus GATEWAY_REJECTED = new TransactionStatus("gateway_rejected");
        public static readonly TransactionStatus PROCESSOR_DECLINED = new TransactionStatus("processor_declined");
        public static readonly TransactionStatus SETTLED = new TransactionStatus("settled");
        public static readonly TransactionStatus SETTLING = new TransactionStatus("settling");
        public static readonly TransactionStatus SUBMITTED_FOR_SETTLEMENT = new TransactionStatus("submitted_for_settlement");
        public static readonly TransactionStatus UNRECOGNIZED = new TransactionStatus("unrecognized");
        public static readonly TransactionStatus VOIDED = new TransactionStatus("voided");

        public static readonly TransactionStatus[] ALL = {
                                                             AUTHORIZATION_EXPIRED, AUTHORIZED, AUTHORIZING, FAILED, GATEWAY_REJECTED, PROCESSOR_DECLINED,
                                                             SETTLED, SETTLING, SUBMITTED_FOR_SETTLEMENT, VOIDED
                                                         };

        protected TransactionStatus(String name) : base(name) { }
    }
}