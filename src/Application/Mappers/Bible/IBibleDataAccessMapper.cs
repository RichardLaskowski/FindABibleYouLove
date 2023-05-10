using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleDataAccessMapper<TType>
    : ISimpleDataAccessMapper<TType, BibleEntity<TType>, BibleContract<TType>> where TType : class
{
}
