using Domain.Base.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleTranslationMapper<TType> : IBaseMapper<BibleTranslationEntity<TType>, BibleTranslationContract> where TType : class
{
}
