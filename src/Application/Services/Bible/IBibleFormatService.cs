using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Bible;

namespace Application.Services.Bible;

public interface IBibleFormatService<TType> : IService<TType, BibleFormatContract<TType>>
    where TType : class
{

}