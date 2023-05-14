using Domain.Common.Classes;
using Domain.Common.Interfaces;

namespace Infrastructure.Repositories;

public class DictionaryRepository<TType, TEntity> : IRepository<TType, TEntity> where TEntity : BaseEntity<TType> where TType : class
{
    protected IDictionary<TType, TEntity> Dictionary = new Dictionary<TType, TEntity>();

    public TEntity Add(TEntity entity) => throw new NotImplementedException();
    public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    public void Remove(TEntity entity) => throw new NotImplementedException();
    public void RemoveRange(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    public TEntity Get(TType id) => throw new NotImplementedException();
    public IEnumerable<TEntity> GetAll() => throw new NotImplementedException();
    public Task<TEntity> GetAsync(TType id) => throw new NotImplementedException();
    public Task<IEnumerable<TEntity>> GetAllAsync() => throw new NotImplementedException();
    public void Update(TEntity entity) => throw new NotImplementedException();
    public void UpdateRange(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate) => throw new NotImplementedException();
    public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate) => throw new NotImplementedException();
}
