using DDD.Core.Messages;

namespace DDD.Core.Handlers
{
    namespace SHS.RD.CGC.Core.DomainEvents
    {
        public interface IMessageHandler
        {
            Task PublishAsync<T>(T messageEvent, CancellationToken cancellationToken)
                where T : IEvent;

            Task SendAsync(ICommand messageCommand, CancellationToken cancellationToken);

            Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> messageCommand, CancellationToken cancellationToken);
        }
    }
}
