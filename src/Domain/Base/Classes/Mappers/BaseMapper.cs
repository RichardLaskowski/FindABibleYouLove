using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;
using Domain.Base.Interfaces;

namespace Domain.Base.Classes.Mappers;
public abstract class BaseMapper<TType, TEntity, TContract> : IBaseMapper<TEntity, TContract>
    where TType : class
    where TEntity : BaseEntity<TType>
    where TContract : BaseContract<TType>
{
    public abstract TEntity Map(TContract value);
    public abstract TContract Map(TEntity value);
    public abstract IEnumerable<TEntity> MapAll(IEnumerable<TContract> values);
    public abstract IEnumerable<TContract> MapAll(IEnumerable<TEntity> values);
    public abstract Task<TEntity> MapAsync(TContract value);
    public abstract Task<TContract> MapAsync(TEntity value);
    public abstract Task<IEnumerable<TEntity>> MapAllAsync(IEnumerable<TContract> values);
    public abstract Task<IEnumerable<TContract>> MapAllAsync(IEnumerable<TEntity> values);
}
