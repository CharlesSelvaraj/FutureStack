namespace FutureStack.DomainModel
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public string Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Company { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
        public string Fax { get; protected set; }
        public string Website { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
        public CreditCard[] CreditCards { get; protected set; }
        public Address[] Addresses { get; protected set; }
        public Dictionary<String, String> CustomFields { get; protected set; }
    }
}
