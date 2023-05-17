using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleCategoryContract(string BibleCategoryId, string CategoryName, string CategoryDescription) : StringBaseContract(BibleCategoryId);