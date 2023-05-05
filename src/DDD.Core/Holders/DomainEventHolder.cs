using System.Collections.Concurrent;
using DDD.Core.Messages;

namespace DDD.Core.Holders;

public abstract class DomainEventHolder
{
    private readonly ConcurrentQueue<IEvent> _domainEvents = new();

    public IReadOnlyCollection<IEvent> DomainEvents => _domainEvents.ToList().AsReadOnly();

    public bool TryRemoveDomainEvent(out IEvent domainEvent)
    {
        return _domainEvents.TryDequeue(out domainEvent!);
    }

    protected void AddDomainEvent<T>(T domainEvent)
        where T : IEvent
    {
        _domainEvents.Enqueue(domainEvent);
    }
}