namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardDebit : Enumeration
    {
        public static readonly CreditCardDebit YES = new CreditCardDebit("Yes");
        public static readonly CreditCardDebit NO = new CreditCardDebit("No");
        public static readonly CreditCardDebit UNKNOWN = new CreditCardDebit("Unknown");

        public static readonly CreditCardDebit[] ALL = {YES, NO, UNKNOWN};

        protected CreditCardDebit(String name) : base(name) {}
    }
}