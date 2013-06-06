namespace FutureStack.DomainModel.Enums
{
    using System;

    public class TransactionGatewayRejectionReason : Enumeration
    {
        public static readonly TransactionGatewayRejectionReason AVS = new TransactionGatewayRejectionReason("avs");
        public static readonly TransactionGatewayRejectionReason AVS_AND_CVV = new TransactionGatewayRejectionReason("avs_and_cvv");
        public static readonly TransactionGatewayRejectionReason CVV = new TransactionGatewayRejectionReason("cvv");
        public static readonly TransactionGatewayRejectionReason DUPLICATE = new TransactionGatewayRejectionReason("duplicate");

        public static readonly TransactionGatewayRejectionReason[] ALL = {
                                                                             AVS, AVS_AND_CVV, CVV, DUPLICATE
                                                                         };

        protected TransactionGatewayRejectionReason(String name) : base(name) { }
    }
}