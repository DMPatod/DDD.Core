namespace DDD.Core.DataPersistence
{
    public interface IDomainContext
    {
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
