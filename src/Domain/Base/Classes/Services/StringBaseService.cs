using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;
using Domain.Base.Interfaces.Mappers;
using Domain.Base.Interfaces.Repositories;
using Domain.Base.Interfaces.Services;

namespace Domain.Base.Classes.Services;

public abstract class StringBaseService<TContract, TEntity> : BaseService<string, TEntity, TContract>, IStringBaseService<TContract>
    where TContract : StringBaseContract
    where TEntity : StringBaseEntity
{
    protected StringBaseService(
        IStringBaseRepository<TEntity> repo,
        IStringBaseMapper<TEntity, TContract> mapper) : base(repo, mapper)
    {
    }
}
