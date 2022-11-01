using ReceiptGenerator.Domain.Common;

namespace ReceiptGenerator.Domain.Entities;

public class Cart : IHasDomainEvent
{
    public IList<DomainEvent> DomainEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
