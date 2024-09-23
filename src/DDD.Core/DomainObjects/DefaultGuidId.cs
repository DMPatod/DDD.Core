
namespace DDD.Core.DomainObjects
{
    public class DefaultGuidId : ValueObject
    {
        public Guid Value { get; set; }

        private DefaultGuidId(Guid value)
        {
            Value = value;
        }

        public static DefaultGuidId Create()
        {
            return new DefaultGuidId(Guid.NewGuid());
        }

        public static DefaultGuidId Create(Guid value)
        {
            return new DefaultGuidId(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
