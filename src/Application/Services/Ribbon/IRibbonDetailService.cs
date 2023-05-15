using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Services.Ribbon;

public interface IRibbonDetailService<TType> : IService<TType, RibbonDetailContract<TType>>
    where TType : class
{

}