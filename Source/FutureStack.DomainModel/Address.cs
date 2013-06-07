namespace FutureStack.DomainModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using ServiceStack.DataAnnotations;

    public class Address
    {
        [AutoIncrement]
        public int Id { get; protected set; }
        [StringLength(255)]
        [References(typeof(Customer))]
        public int CustomerId { get; protected set; }
        [StringLength(255)]
        public string FirstName { get; protected set; }
        [StringLength(255)]
        public string LastName { get; protected set; }
        [StringLength(255)]
        public string Company { get; protected set; }
        [StringLength(255)]
        public string StreetAddress { get; protected set; }
        [StringLength(255)]
        public string ExtendedAddress { get; protected set; }
        [StringLength(255)]
        public string Locality { get; protected set; }
        [StringLength(255)]
        public string Region { get; protected set; }
        [StringLength(255)]
        public string PostalCode { get; protected set; }
        [StringLength(255)]
        public string CountryCodeAlpha2 { get; protected set; }
        [StringLength(255)]
        public string CountryCodeAlpha3 { get; protected set; }
        [StringLength(255)]
        public string CountryCodeNumeric { get; protected set; }
        [StringLength(255)]
        public string CountryName { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
    }
}