namespace FutureStack.DomainModel
{
    using System;

    public class Modification
    {
        public Decimal? Amount { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public String Description { get; protected set; }
        public String Id { get; protected set; }
        public String Kind { get; protected set; }
        public String MerchantId { get; protected set; }
        public String Name { get; protected set; }
        public Boolean? NeverExpires { get; protected set; }
        public Int32? NumberOfBillingCycles { get; protected set; }
        public Int32? Quantity { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
    }
}