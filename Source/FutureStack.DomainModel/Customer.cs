namespace FutureStack.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using ServiceStack.DataAnnotations;

    public class Customer
    {
        [AutoIncrement]
        public int Id { get; protected set; }
        [Index(Unique = true)]
        [StringLength(255)]
        public string CustomerUniqueId { get; protected set; }
        [StringLength(255)]
        public string FirstName { get; protected set; }
        [StringLength(255)]
        public string LastName { get; protected set; }
        [StringLength(255)]
        public string Company { get; protected set; }
        [Index(Unique = true)]
        [StringLength(255)]
        public string Email { get; protected set; }
        [StringLength(255)]
        public string Phone { get; protected set; }
        [StringLength(255)]
        public string Fax { get; protected set; }
        [StringLength(255)]
        public string Website { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
        [Ignore]
        public CreditCard[] CreditCards { get; protected set; }
        [Ignore]
        public Address[] Addresses { get; protected set; }
        public Dictionary<string, string> CustomFields { get; protected set; }
    }
}
