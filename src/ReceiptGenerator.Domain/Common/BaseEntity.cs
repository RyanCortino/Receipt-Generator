namespace ReceiptGenerator.Domain.Common;

public class BaseEntity
{
    public int Id { get; set; }

    private readonly ICollection<BaseEvent> _domainEvents = new List<BaseEvent>();
}
