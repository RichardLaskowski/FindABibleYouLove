using System.Collections.ObjectModel;

using Domain.Base.Classes.Entities;
using Domain.Base.Interfaces.Repositories;

namespace Domain.Base.Classes.Repositories;
public abstract class InMemoryRepository<TType, TEntity> : IInMemoryRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    protected ICollection<TEntity> entities;
    public InMemoryRepository()
    {
        entities = new Collection<TEntity>();
    }
    public abstract void Seed();
    public abstract TEntity Add(TEntity entity);
    public abstract IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
    public abstract void Remove(TEntity entity);
    public abstract void RemoveRange(IEnumerable<TEntity> entities);
    public abstract TEntity Get(TType id);
    public abstract IEnumerable<TEntity> GetAll();
    public abstract Task<TEntity> GetAsync(TType id);
    public abstract Task<IEnumerable<TEntity>> GetAllAsync();
    public abstract void Update(TEntity entity);
    public abstract void UpdateRange(IEnumerable<TEntity> entities);
    public abstract IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    public abstract Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
}
