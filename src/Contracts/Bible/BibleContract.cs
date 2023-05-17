using Domain.Base.Classes.Contracts;
using FindABibleYouLove.Contracts.Cover;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleContract(
    string BibleId,
    BibleCategoryContract BibleCategory,
    CoverContract Cover)
    : StringBaseContract(BibleId);