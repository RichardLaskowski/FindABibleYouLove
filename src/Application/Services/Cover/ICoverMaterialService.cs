using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Cover;

namespace Application.Services.Cover;

public interface ICoverMaterialService<TType>
    : IService<TType, CoverMaterialContract<TType>>
    where TType : class
{

}