using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleTranslationContract<TType>(
    TType BibleTranslationID,
    string TranslationName,
    string TranslationAbbreviation,
    string TranslationDescription)
    : BaseContract<TType>(ID: BibleTranslationID) where TType : class;