using Domain.Common.Classes;
using Domain.Common.Interfaces;

namespace Infrastructure.Repositories;

public abstract class ListRepository<TType, TEntity> : IRepository<TType, TEntity> 
    where TType : class
    where TEntity : BaseEntity<TType> 
{
    protected IList<TEntity> List = new List<TEntity>();

    public abstract TEntity Add(TEntity entity);
    public abstract IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
    public abstract IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    public abstract Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
    public abstract TEntity Get(TType id);
    public abstract IEnumerable<TEntity> GetAll();
    public abstract Task<IEnumerable<TEntity>> GetAllAsync();
    public abstract Task<TEntity> GetAsync(TType id);
    public abstract void Remove(TEntity entity);
    public abstract void RemoveRange(IEnumerable<TEntity> entities);
    public abstract void Update(TEntity entity);
    public abstract void UpdateRange(IEnumerable<TEntity> entities);
}
