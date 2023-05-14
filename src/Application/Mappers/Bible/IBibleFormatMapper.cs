using Domain.Common.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleFormatMapper<TType> : IMapper<BibleFormatEntity<TType>, BibleFormatContract<TType>> where TType : class
{
}
