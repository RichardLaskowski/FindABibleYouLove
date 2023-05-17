using Domain.Base.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonSizeRepository<TType> : IBaseRepository<TType, RibbonSizeEntity<TType>> where TType : class
{

}