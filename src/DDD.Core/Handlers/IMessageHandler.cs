using DDD.Core.Messages;

namespace DDD.Core.Handlers
{
    namespace SHS.RD.CGC.Core.DomainEvents
    {
        public interface IDomainMessageHandler
        {
            Task PublishAsync<T>(T domainEvent, CancellationToken cancellationToken)
                where T : IEvent;

            Task SendAsync(ICommand domainCommand, CancellationToken cancellationToken);

            Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> domainCommand, CancellationToken cancellationToken);
        }
    }
}
