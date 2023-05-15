using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Services.Ribbon;

public interface IRibbonSizeService<TType> : IService<TType, RibbonSizeContract<TType>>
    where TType : class
{

}