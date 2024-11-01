using DDD.Core.DomainObjects;

namespace DDD.Core.Repositories
{
    public interface IBaseRepository<T, TId>
        where T : Entity<TId>
        where TId : notnull
    {
        Task<T?> FindAsync(TId id, CancellationToken cancellationToken = default);

        Task<IQueryable<T>> FindAsync(CancellationToken cancellationToken = default);

        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);

        // TODO: Create a method to use on PATCH endpoint
        //Task UpdatePropertieAsync(TId id, (string, object) path, CancellationToken cancellationToken = default);

        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}
