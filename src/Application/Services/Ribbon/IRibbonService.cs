using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Services.Ribbon;

public interface IRibbonService<TType> : IService<TType, RibbonContract<TType>>
    where TType : class
{

}