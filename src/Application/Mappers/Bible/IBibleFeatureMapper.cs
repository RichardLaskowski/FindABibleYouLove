using Domain.Common.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleFeatureMapper<TType> : IMapper<BibleFeatureEntity<TType>, BibleFeatureContract<TType>> where TType : class
{
}