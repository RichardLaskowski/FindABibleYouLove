using Domain.Entities.Ribbon;
using Domain.Common.Interfaces;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonSizeMapper<TType>
    : IMapper<RibbonSizeEntity<TType>, RibbonSizeContract<TType>>
    where TType : class
{
}
