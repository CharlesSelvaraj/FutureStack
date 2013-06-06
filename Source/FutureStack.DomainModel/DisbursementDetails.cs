namespace FutureStack.DomainModel
{
    using System;

    public class DisbursementDetails
    {
        public Decimal? SettlementAmount { get; protected set; }
        public String SettlementCurrencyIsoCode { get; protected set; }
        public String SettlementCurrencyExchangeRate { get; protected set; }
        public Boolean? FundsHeld { get; protected set; }
        public DateTime? DisbursementDate { get; protected set; }
        public Boolean IsValid()
        {
            return DisbursementDate != null;
        }
    }
}