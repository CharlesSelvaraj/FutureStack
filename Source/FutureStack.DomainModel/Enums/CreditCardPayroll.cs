namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardPayroll : Enumeration
    {
        public static readonly CreditCardPayroll YES = new CreditCardPayroll("Yes");
        public static readonly CreditCardPayroll NO = new CreditCardPayroll("No");
        public static readonly CreditCardPayroll UNKNOWN = new CreditCardPayroll("Unknown");

        public static readonly CreditCardPayroll[] ALL = {YES, NO, UNKNOWN};

        protected CreditCardPayroll(String name) : base(name) {}
    }
}