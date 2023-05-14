using Domain.Common.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonDetailRepository<TType> : IRepository<TType, RibbonDetailEntity<TType>> where TType : class
{

}