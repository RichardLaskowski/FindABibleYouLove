using Domain.Base.Classes.Entities;

namespace Domain.Base.Interfaces;
public interface IStringBaseRepository<TEntity> : IBaseRepository<string, TEntity> 
    where TEntity : StringBaseEntity
{
}
