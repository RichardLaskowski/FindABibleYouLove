using Domain.Base.Classes.Entities;

namespace Domain.Base.Classes.Repositories;

public abstract class DictionaryRepository<TType, TEntity> : InMemoryRepository<TType, TEntity> 
    where TType : class
    where TEntity : BaseEntity<TType>
{
    protected IDictionary<string, TEntity> Dictionary = new Dictionary<string, TEntity>();

    protected DictionaryRepository() : base() { }
}
