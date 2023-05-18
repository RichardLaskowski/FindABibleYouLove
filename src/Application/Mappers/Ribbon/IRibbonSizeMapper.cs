using Domain.Base.Interfaces.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonSizeMapper : IStringBaseMapper<RibbonSizeEntity, RibbonSizeContract> { }
