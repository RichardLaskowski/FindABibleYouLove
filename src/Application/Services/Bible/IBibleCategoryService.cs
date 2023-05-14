using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Bible;

namespace Application.Services.Bible;

public interface IBibleCategoryService<TType>
    : IService<TType, BibleCategoryContract<TType>>
    where TType : class
{

}