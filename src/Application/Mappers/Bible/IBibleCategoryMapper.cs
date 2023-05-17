using Domain.Base.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleCategoryMapper<TType> : IBaseMapper<BibleCategoryEntity, BibleCategoryContract> where TType : class
{
}