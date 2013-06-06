namespace FutureStack.DomainModel.Enums
{
    using System;

    public class TransactionCreatedUsing : Enumeration
    {
        public static readonly TransactionCreatedUsing FULL_INFORMATION = new TransactionCreatedUsing("full_information");
        public static readonly TransactionCreatedUsing TOKEN = new TransactionCreatedUsing("token");

        public static readonly TransactionCreatedUsing[] ALL = { FULL_INFORMATION, TOKEN };

        protected TransactionCreatedUsing(String name) : base(name) { }
    }
}