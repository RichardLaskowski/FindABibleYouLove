using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;

namespace Domain.Base.Interfaces.Mappers;
public interface IStringBaseMapper<TEntity, TContract> : IBaseMapper<string, TEntity, TContract>
    where TEntity : StringBaseEntity
    where TContract : StringBaseContract
{
}
