using Domain.Base.Interfaces;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Mappers.Ribbon;

public interface IRibbonColorMapper<TType> : IBaseMapper<RibbonColorEntity<TType>, RibbonColorContract> where TType : class { }
