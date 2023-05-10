using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverDataAccessMapper<TType>
    : ISimpleDataAccessMapper<TType, CoverEntity<TType>, CoverContract<TType>> where TType : class
{
}
