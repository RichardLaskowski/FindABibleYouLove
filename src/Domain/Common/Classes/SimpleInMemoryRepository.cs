using Domain.Common.Interfaces;

namespace Domain.Common.Classes;
public class SimpleInMemoryRepository<TType, TEntity> : ISimpleRepository<TType, TEntity> 
    where TType : class 
    where TEntity : SimpleEntity<TType>
{
     protected Dictionary<TType, TEntity> Entities = new Dictionary<TType, TEntity>();

    #region Public Methods

    public TEntity Add(TEntity entity)
    {
        try
        {
            Entities.Add(entity.Id!, entity);
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (NotSupportedException)
        {
            throw;
        }

        return entity;
    }
    public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
    {
        foreach (TEntity entity in entities)
        {
            Add(entity);
        }

        return entities;
    }
    public void Remove(TEntity entity)
    {
        try
        {
            Entities.Remove(entity.Id!);
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (NotSupportedException)
        {
            throw;
        }
    }
    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        foreach (TEntity entity in entities)
        {
            Remove(entity);
        }
    }
    public TEntity Get(TType id) => Entities[id];
    public IEnumerable<TEntity> GetAll() => Entities.Values;
    public async Task<TEntity> GetAsync(TType id) => await Task.Run(() => Get(id));
    public async Task<IEnumerable<TEntity>> GetAllAsync() => await Task.Run(() => GetAll());
    public void Update(TEntity entity) => throw new NotImplementedException();
    public void UpdateRange(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate) => Entities.Values.Where(predicate);
    public async Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate) => await Task.Run(() => Find(predicate));

    #endregion Public Methods
}
