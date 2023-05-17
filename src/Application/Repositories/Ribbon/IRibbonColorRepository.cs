using Domain.Base.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonColorRepository<TType> : IBaseRepository<TType, RibbonColorEntity<TType>> where TType : class
{

}