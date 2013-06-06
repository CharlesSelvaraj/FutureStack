namespace FutureStack.DomainModel
{
    using System;

    public class Address
    {
        public String Id { get; protected set; }
        public String CustomerId { get; protected set; }
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public String Company { get; protected set; }
        public String StreetAddress { get; protected set; }
        public String ExtendedAddress { get; protected set; }
        public String Locality { get; protected set; }
        public String Region { get; protected set; }
        public String PostalCode { get; protected set; }
        public String CountryCodeAlpha2 { get; protected set; }
        public String CountryCodeAlpha3 { get; protected set; }
        public String CountryCodeNumeric { get; protected set; }
        public String CountryName { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
    }
}