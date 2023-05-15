using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Bible;

namespace Application.Services.Bible;

public interface IBibleFeatureService<TType> : IService<TType, BibleFeatureContract<TType>>
    where TType : class
{

}