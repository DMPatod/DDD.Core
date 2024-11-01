using DDD.Core.DomainObjects;

namespace DDD.Core.Repositories
{
    public interface IPageRepository<T>
    {
        Task<IPaginatedCollection<T>> FindPaginatedAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    }
}
