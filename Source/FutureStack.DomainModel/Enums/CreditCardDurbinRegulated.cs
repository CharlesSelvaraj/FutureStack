namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardDurbinRegulated : Enumeration
    {
        public static readonly CreditCardDurbinRegulated YES = new CreditCardDurbinRegulated("Yes");
        public static readonly CreditCardDurbinRegulated NO = new CreditCardDurbinRegulated("No");
        public static readonly CreditCardDurbinRegulated UNKNOWN = new CreditCardDurbinRegulated("Unknown");

        public static readonly CreditCardDurbinRegulated[] ALL = {YES, NO, UNKNOWN};

        protected CreditCardDurbinRegulated(String name) : base(name) {}
    }
}