using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Cover;

namespace Application.Services.Cover;

public interface ICoverService<TType>
    : IService<TType, CoverContract<TType>>
    where TType : class
{

}