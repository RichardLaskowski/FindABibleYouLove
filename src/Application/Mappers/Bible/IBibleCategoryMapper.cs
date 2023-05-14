using Domain.Common.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleCategoryMapper<TType> : IMapper<BibleCategoryEntity<TType>, BibleCategoryContract<TType>> where TType : class
{
}