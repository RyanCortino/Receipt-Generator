﻿namespace ReceiptGenerator.Domain.Common
{
    public interface IHasDomainEvent
    {
        public IList<DomainEvent> DomainEvents { get; set; }
    }

    public abstract class DomainEvent
    {
        protected DomainEvent()
        {
            DateOccurred = DateTimeOffset.UtcNow;
        }

        public bool IsPublished {get; set;}
        public DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
