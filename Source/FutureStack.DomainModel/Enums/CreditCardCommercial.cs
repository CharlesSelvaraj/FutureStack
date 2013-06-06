namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardCommercial : Enumeration
    {
        public static readonly CreditCardCommercial YES = new CreditCardCommercial("Yes");
        public static readonly CreditCardCommercial NO = new CreditCardCommercial("No");
        public static readonly CreditCardCommercial UNKNOWN = new CreditCardCommercial("Unknown");

        public static readonly CreditCardCommercial[] ALL = {YES, NO, UNKNOWN};

        protected CreditCardCommercial(String name) : base(name) {}
    }
}