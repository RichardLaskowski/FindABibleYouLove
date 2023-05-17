using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;
using Domain.Base.Interfaces;

namespace Application.Mappers.Ribbon;

public interface IRibbonSizeMapper<TType>
    : IBaseMapper<RibbonSizeEntity<TType>, RibbonSizeContract>
    where TType : class
{
}
