using Domain.Common.Classes;
using FindABibleYouLove.Contracts.Cover;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleContract<TType>(
    TType BibleID,
    BibleCategoryContract<TType> BibleCategory,
    CoverContract<TType> Cover)
    : BaseContract<TType>(ID: BibleID) where TType : class;