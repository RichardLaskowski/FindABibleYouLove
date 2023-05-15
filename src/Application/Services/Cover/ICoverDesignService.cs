using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Cover;

namespace Application.Services.Cover;

public interface ICoverDesignService<TType> : IService<TType, CoverDesignContract<TType>>
    where TType : class
{

}