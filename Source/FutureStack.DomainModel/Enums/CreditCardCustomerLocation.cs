    namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardCustomerLocation : Enumeration
    {
        public static readonly CreditCardCustomerLocation US = new CreditCardCustomerLocation("us");
        public static readonly CreditCardCustomerLocation INTERNATIONAL = new CreditCardCustomerLocation("international");
        public static readonly CreditCardCustomerLocation UNRECOGNIZED = new CreditCardCustomerLocation("unrecognized");

        public static readonly CreditCardCustomerLocation[] ALL = {US, INTERNATIONAL};

        protected CreditCardCustomerLocation(String name) : base(name) {}
    }
}