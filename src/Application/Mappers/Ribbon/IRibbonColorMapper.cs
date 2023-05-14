using Domain.Common.Interfaces;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonColorMapper<TType> : IMapper<RibbonColorEntity<TType>, RibbonColorContract<TType>> where TType : class { }
