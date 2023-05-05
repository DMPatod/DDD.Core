using MediatR;

namespace DDD.Core.Handlers
{
    public interface IEventHandler<in TEvent> : INotificationHandler<TEvent>
        where TEvent : INotification
    {
    }
}
