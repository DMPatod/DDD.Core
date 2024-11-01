using DDD.Core.Messages;
using FluentResults;

namespace DDD.Core.Handlers
{
    public interface IResultCommandHandler<in TResultCommand> : IResultCommandHandler<TResultCommand, bool>
        where TResultCommand : IResultCommand
    {
    }

    public interface IResultCommandHandler<in TResultCommand, TResponse> : ICommandHandler<TResultCommand, Result<TResponse>>
        where TResultCommand : IResultCommand<TResponse>
    {
    }
}
