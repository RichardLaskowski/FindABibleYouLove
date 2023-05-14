using Domain.Common.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleCategoryRepository<TType> : IRepository<TType, BibleCategoryEntity<TType>> where TType : class
{

}