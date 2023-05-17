using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;

namespace Domain.Base.Classes.Mappers;
public abstract class StringBaseMapper<TEntity, TContract> : BaseMapper<string,TEntity, TContract>
    where TEntity : StringBaseEntity
    where TContract : StringBaseContract
{
}
