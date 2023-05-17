using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleTranslationContract(
    string BibleTranslationId,
    string TranslationName,
    string TranslationAbbreviation,
    string TranslationDescription)
    : StringBaseContract(BibleTranslationId);