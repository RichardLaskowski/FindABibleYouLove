using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleCategoryContract<TType>(
    TType BibleCategoryID,
    string CategoryName,
    string CategoryDescription)
    : BaseContract<TType>(BibleCategoryID) where TType : class;