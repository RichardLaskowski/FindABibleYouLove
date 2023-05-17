using Domain.Base.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleFormatMapper<TType> : IBaseMapper<BibleFormatEntity<TType>, BibleFormatContract> where TType : class
{
}
