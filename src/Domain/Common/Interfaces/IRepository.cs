using Domain.Common.Classes;

namespace Domain.Common.Interfaces;

public interface IRepository<TType, TEntity> 
    where TType : class
    where TEntity : BaseEntity<TType>
{
    #region Add

    TEntity Add(TEntity entity);
    IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);

    #endregion Add

    #region Remove

    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);

    #endregion Remove

    #region Get

    TEntity Get(TType id);
    IEnumerable<TEntity> GetAll();
    Task<TEntity> GetAsync(TType id);
    Task<IEnumerable<TEntity>> GetAllAsync();

    #endregion Get

    #region Update

    void Update(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);

    #endregion

    #region Find

    IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);

    #endregion Find
}
