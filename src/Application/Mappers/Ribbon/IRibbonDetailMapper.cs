using Domain.Entities.Ribbon;
using Domain.Common.Interfaces;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonDetailMapper<TType>
    : IMapper<RibbonDetailEntity<TType>, RibbonDetailContract<TType>>
    where TType : class
{
}
