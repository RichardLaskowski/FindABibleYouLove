using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Bible;

namespace Application.Services.Bible;

public interface IBibleService<TType> : IService<TType, BibleContract<TType>>
    where TType : class
{

}