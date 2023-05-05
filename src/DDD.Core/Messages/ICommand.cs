using MediatR;

namespace DDD.Core.Messages;

public interface ICommand : ICommand<bool>
{
}

public interface ICommand<out T> : IRequest<T>
{
}