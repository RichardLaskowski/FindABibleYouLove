using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;

namespace Domain.Base.Interfaces;

public interface IBaseMapper<TType, TEntity, TContract>
    where TType : class
    where TEntity : BaseEntity<TType>
    where TContract: BaseContract<TType>
{
    TEntity Map(TContract contract);
    TContract Map(TEntity entity);

    IEnumerable<TEntity> MapAll(IEnumerable<TContract> contracts);
    IEnumerable<TContract> MapAll(IEnumerable<TEntity> entities);

    Task<TEntity> MapAsync(TContract contract);
    Task<TContract> MapAsync(TEntity entities);

    Task<IEnumerable<TEntity>> MapAllAsync(IEnumerable<TContract> contracts);
    Task<IEnumerable<TContract>> MapAllAsync(IEnumerable<TEntity> entities);
}
