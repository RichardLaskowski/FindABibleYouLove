using Domain.Common.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleMapper<TType> : IMapper<BibleEntity<TType>, BibleContract<TType>> where TType : class
{
}
