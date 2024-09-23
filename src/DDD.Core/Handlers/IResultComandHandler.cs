using DDD.Core.Messages;
using FluentResults;

namespace DDD.Core.Handlers
{
    public interface IResultCommandHandler<in TResultCommand> : IResultComandHandler<TResultCommand, bool>
        where TResultCommand : IResultCommand
    {
    }

    public interface IResultComandHandler<in TResultCommand, TResponse> : ICommandHandler<TResultCommand, Result<TResponse>>
        where TResultCommand : IResultCommand<TResponse>
    {
    }
}
