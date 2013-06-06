namespace FutureStack.DomainModel.Enums
{
    using System;

    public class CreditCardCardType : Enumeration
    {
        public static readonly CreditCardCardType AMEX = new CreditCardCardType("American Express");
        public static readonly CreditCardCardType CARTE_BLANCHE = new CreditCardCardType("Carte Blanche");
        public static readonly CreditCardCardType CHINA_UNION_PAY = new CreditCardCardType("China UnionPay");
        public static readonly CreditCardCardType DINERS_CLUB_INTERNATIONAL = new CreditCardCardType("Diners Club");
        public static readonly CreditCardCardType DISCOVER = new CreditCardCardType("Discover");
        public static readonly CreditCardCardType JCB = new CreditCardCardType("JCB");
        public static readonly CreditCardCardType LASER = new CreditCardCardType("Laser");
        public static readonly CreditCardCardType MAESTRO = new CreditCardCardType("Maestro");
        public static readonly CreditCardCardType MASTER_CARD = new CreditCardCardType("MasterCard");
        public static readonly CreditCardCardType SOLO = new CreditCardCardType("Solo");
        public static readonly CreditCardCardType SWITCH = new CreditCardCardType("Switch");
        public static readonly CreditCardCardType VISA = new CreditCardCardType("Visa");
        public static readonly CreditCardCardType UNKNOWN = new CreditCardCardType("Unknown");
        public static readonly CreditCardCardType UNRECOGNIZED = new CreditCardCardType("Unrecognized");

        public static readonly CreditCardCardType[] ALL = {
                                                              AMEX, CARTE_BLANCHE, CHINA_UNION_PAY, DINERS_CLUB_INTERNATIONAL, DISCOVER,
                                                              JCB, LASER, MAESTRO, MASTER_CARD, SOLO, SWITCH, VISA, UNKNOWN
                                                          };

        protected CreditCardCardType(String name) : base(name) {}
    }
}