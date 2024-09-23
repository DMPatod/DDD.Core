namespace DDD.Core.DataPersistence
{
    public interface IDomainContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
