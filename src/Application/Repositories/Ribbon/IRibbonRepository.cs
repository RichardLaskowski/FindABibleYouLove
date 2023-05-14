using Domain.Common.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonRepository<TType> : IRepository<TType, RibbonEntity<TType>> where TType : class
{

}