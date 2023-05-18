using Domain.Base.Classes.Entities;

namespace Domain.Base.Interfaces.Repositories;
public interface IStringBaseRepository<TEntity> : IBaseRepository<string, TEntity>
    where TEntity : StringBaseEntity
{
}
