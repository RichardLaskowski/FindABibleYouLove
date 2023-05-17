using Domain.Base.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonDetailRepository<TType> : IBaseRepository<TType, RibbonDetailEntity<TType>> where TType : class
{

}