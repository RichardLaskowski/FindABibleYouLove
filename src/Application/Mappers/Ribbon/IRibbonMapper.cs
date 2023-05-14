using Domain.Entities.Ribbon;
using Domain.Common.Interfaces;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonMapper<TType>
    : IMapper<RibbonEntity<TType>, RibbonContract<TType>>
    where TType : class
{
}
