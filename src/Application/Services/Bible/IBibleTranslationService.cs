using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Bible;

namespace Application.Services.Bible;

public interface IBibleTranslationService<TType>
    : IService<TType, BibleTranslationContract<TType>>
    where TType : class
{

}