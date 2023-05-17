using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;
using Domain.Base.Interfaces;

namespace Application.Mappers.Ribbon;

public interface IRibbonDetailMapper<TType>
    : IBaseMapper<RibbonDetailEntity<TType>, RibbonDetailContract>
    where TType : class
{
}
