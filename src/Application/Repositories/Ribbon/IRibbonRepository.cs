using Domain.Base.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonRepository<TType> : IBaseRepository<TType, RibbonEntity<TType>> where TType : class
{

}