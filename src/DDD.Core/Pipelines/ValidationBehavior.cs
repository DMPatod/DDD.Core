using DDD.Core.Messages;
using FluentValidation;
using MediatR;

namespace DDD.Core.Pipelines
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : ICommand<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var ctx = new ValidationContext<TRequest>(request);

            var failures = _validators.Select(x => x.Validate(ctx)).SelectMany(x => x.Errors)
                .Where(x => x is not null);

            return failures.Any() ? throw new ValidationException(failures) : next();
        }
    }
}
