namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardHealthcare : Enumeration
    {
        public static readonly CreditCardHealthcare YES = new CreditCardHealthcare("Yes");
        public static readonly CreditCardHealthcare NO = new CreditCardHealthcare("No");
        public static readonly CreditCardHealthcare UNKNOWN = new CreditCardHealthcare("Unknown");

        public static readonly CreditCardHealthcare[] ALL = {YES, NO, UNKNOWN};

        protected CreditCardHealthcare(String name) : base(name) {}
    }
}