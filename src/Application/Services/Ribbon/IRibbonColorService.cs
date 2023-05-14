using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Ribbon;

namespace Application.Services.Ribbon;

public interface IRibbonColorService<TType>
    : IService<TType, RibbonColorContract<TType>>
    where TType : class
{

}