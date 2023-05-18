using Domain.Base.Classes.Entities;

namespace Domain.Base.Interfaces.Repositories;
public interface IInMemoryRepository<TType, TEntity> : IBaseRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    void Seed();
}
