using Domain.Base.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleFeatureMapper<TType> : IBaseMapper<BibleFeatureEntity<TType>, BibleFeatureContract> where TType : class
{
}