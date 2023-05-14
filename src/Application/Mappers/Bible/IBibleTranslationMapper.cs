using Domain.Common.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleTranslationMapper<TType> : IMapper<BibleTranslationEntity<TType>, BibleTranslationContract<TType>> where TType : class
{
}
