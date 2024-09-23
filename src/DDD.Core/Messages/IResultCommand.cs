using FluentResults;

namespace DDD.Core.Messages
{
    public interface IResultCommand : IResultCommand<bool>
    {
    }

    public interface IResultCommand<T> : ICommand<Result<T>>
    {
    }
}
