namespace FutureStack.DomainModel
{
    using System;
    using Enums;

    public class StatusEvent
    {
        public Decimal? Amount { get; protected set; }
        public TransactionStatus Status { get; protected set; }
        public DateTime? Timestamp { get; protected set; }
        public TransactionSource Source { get; protected set; }
        public String User { get; protected set; }
    }
}