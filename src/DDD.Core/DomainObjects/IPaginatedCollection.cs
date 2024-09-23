namespace DDD.Core.DomainObjects
{
    public interface IPaginatedCollection<T>
    {
        int Page { get; }
        int PageSize { get; }
        int TotalPages { get; }
        int TotalItems { get; }
        ICollection<T> Items { get; }
    }
}
