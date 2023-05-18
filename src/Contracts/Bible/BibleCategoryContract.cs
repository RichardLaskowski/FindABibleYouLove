using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleCategoryContract(string Id, string CategoryName, string CategoryDescription) : StringBaseContract(Id);