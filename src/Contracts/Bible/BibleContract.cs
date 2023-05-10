using Domain.Common.Classes;
using FindABibleYouLove.Contracts.Cover;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleContract<TType>(
    TType                           BibleID,
    BibleCategoryContract<TType>    BibleCategory,
    CoverContract<TType>            Cover) : SimpleAPIContract<TType>(BibleID) where TType : class;