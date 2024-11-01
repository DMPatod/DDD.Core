namespace DDD.Core.DomainObjects
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedAt { get; set; }
    }
}
