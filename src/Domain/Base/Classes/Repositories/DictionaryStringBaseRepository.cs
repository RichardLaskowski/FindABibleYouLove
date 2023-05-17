using Domain.Base.Classes.Entities;
using Domain.Base.Interfaces;

namespace Domain.Base.Classes.Repositories;

public abstract class DictionaryStringBaseRepository<TEntity> : IStringBaseRepository<TEntity>
    where TEntity : StringBaseEntity
{
    protected IDictionary<string, TEntity> Dictionary = new Dictionary<string, TEntity>();

    protected DictionaryStringBaseRepository() : base() => Seed();

    public abstract TEntity Add(TEntity entity);
    public abstract IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
    public abstract void Remove(TEntity entity);
    public abstract void RemoveRange(IEnumerable<TEntity> entities);
    public abstract TEntity Get(string id);
    public abstract IEnumerable<TEntity> GetAll();
    public abstract Task<TEntity> GetAsync(string id);
    public abstract Task<IEnumerable<TEntity>> GetAllAsync();
    public abstract void Update(TEntity entity);
    public abstract void UpdateRange(IEnumerable<TEntity> entities);
    public abstract IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    public abstract Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
    public abstract void Seed();
}
