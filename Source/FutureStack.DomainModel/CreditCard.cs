namespace FutureStack.DomainModel
{
    using System;
    using Enums;

    public class CreditCard
    {
        public static readonly String CountryOfIssuanceUnknown = "Unknown";
        public static readonly String IssuingBankUnknown = "Unknown";

        public String Bin { get; protected set; }
        public String CardholderName { get; protected set; }
        public CreditCardCardType CardType { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public String CustomerId { get; protected set; }
        public Boolean? IsDefault { get; protected set; }
        public Boolean? IsVenmoSdk { get; protected set; }
        public Boolean? IsExpired { get; protected set; }
        public CreditCardCustomerLocation CustomerLocation { get; protected set; }
        public String LastFour { get; protected set; }
        public String UniqueNumberIdentifier { get; protected set; }
        public Subscription[] Subscriptions { get; protected set; }
        public String Token { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
        public Address BillingAddress { get; protected set; }
        public String ExpirationMonth { get; protected set; }
        public String ExpirationYear { get; protected set; }
        public CreditCardPrepaid Prepaid { get; protected set; }
        public CreditCardPayroll Payroll { get; protected set; }
        public CreditCardDebit Debit { get; protected set; }
        public CreditCardCommercial Commercial { get; protected set; }
        public CreditCardHealthcare Healthcare { get; protected set; }
        public CreditCardDurbinRegulated DurbinRegulated { get; protected set; }

        private String _countryOfIssuance;

        public String CountryOfIssuance
        {
            get {
                return _countryOfIssuance == "" ? CountryOfIssuanceUnknown : _countryOfIssuance;
            }
        }

        private String _issuingBank;

        public String IssuingBank
        {
            get {
                return _issuingBank == "" ? IssuingBankUnknown : _issuingBank;
            }
        }

        public String ExpirationDate
        {
            get { return ExpirationMonth + "/" + ExpirationYear; }
            protected set
            {
                ExpirationMonth = value.Split('/')[0];
                ExpirationYear = value.Split('/')[1];
            }
        }

        public String MaskedNumber
        {
            get { return String.Format("{0}******{1}", Bin, LastFour); }
        }
    }
}