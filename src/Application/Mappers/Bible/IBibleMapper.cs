using Domain.Base.Interfaces;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleMapper<TType> : IBaseMapper<BibleEntity<TType>, BibleContract> where TType : class
{
}
