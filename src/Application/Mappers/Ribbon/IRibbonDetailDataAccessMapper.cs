using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonDetailDataAccessMapper<TType>
    : ISimpleDataAccessMapper<TType, RibbonDetailEntity<TType>, RibbonDetailContract<TType>>
    where TType : class
{
}
