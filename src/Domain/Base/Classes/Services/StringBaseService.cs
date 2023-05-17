using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;
using Domain.Base.Interfaces;

namespace Domain.Base.Classes.Services;

public abstract class StringBaseService<TContract, TEntity> : BaseService<string, TEntity, TContract>, IStringBaseService<TContract>
    where TContract : StringBaseContract
    where TEntity : StringBaseEntity
{
    protected StringBaseService(
        IBaseRepository<string, TEntity> repo,
        IBaseMapper<TEntity, TContract> mapper) : base(repo, mapper)
    {
    }
}
