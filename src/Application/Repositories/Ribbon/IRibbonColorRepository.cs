using Domain.Common.Interfaces;
using Domain.Entities.Ribbon;

namespace Application.Repositories.Ribbon;

public interface IRibbonColorRepository<TType> : IRepository<TType, RibbonColorEntity<TType>> where TType : class
{

}