using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;
using Domain.Base.Interfaces;

namespace Application.Mappers.Ribbon;

public interface IRibbonMapper<TType>
    : IBaseMapper<RibbonEntity<TType>, RibbonContract>
    where TType : class
{
}
