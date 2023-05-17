using Domain.Base.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleCategoryRepository<TType> : IBaseRepository<TType, BibleCategoryEntity> where TType : class
{

}