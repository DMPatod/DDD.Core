using DDD.Core.Handlers.SHS.RD.CGC.Core.DomainEvents;
using DDD.Core.Messages;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace DDD.Core.Handlers
{
    public class DefaultMessageHandler : IMessageHandler
    {
        private readonly IMediator _mediator;

        public DefaultMessageHandler(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public Task PublishAsync<T>(T domainEvent, CancellationToken cancellationToken)
            where T : IEvent
        {
            return _mediator.Publish(domainEvent, cancellationToken);
        }

        public Task SendAsync(ICommand domainCommand, CancellationToken cancellationToken)
        {
            return _mediator.Send(domainCommand, cancellationToken);
        }

        public Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> domainCommand,
            CancellationToken cancellationToken)
        {
            return _mediator.Send(domainCommand, cancellationToken);
        }
    }

    public static class DefaultMessageHandlerDIExtension
    {
        public static IServiceCollection AddDefaultMessageHandler(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.TryAddTransient<IMessageHandler, DefaultMessageHandler>();
            return services;
        }
    }
}