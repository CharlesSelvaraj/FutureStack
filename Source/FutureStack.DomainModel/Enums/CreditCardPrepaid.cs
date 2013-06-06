namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardPrepaid : Enumeration
    {
        public static readonly CreditCardPrepaid YES = new CreditCardPrepaid("Yes");
        public static readonly CreditCardPrepaid NO = new CreditCardPrepaid("No");
        public static readonly CreditCardPrepaid UNKNOWN = new CreditCardPrepaid("Unknown");

        public static readonly CreditCardPrepaid[] ALL = {YES, NO, UNKNOWN};

        protected CreditCardPrepaid(String name) : base(name) {}
    }
}