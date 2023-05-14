using Domain.Common.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonSizeRepository<TType> : IRepository<TType, RibbonSizeEntity<TType>> where TType : class
{

}