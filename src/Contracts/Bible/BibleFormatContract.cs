using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleFormatContract(
    string BibleFormatId,
    string FormatName,
    string FormatDescription)
    : StringBaseContract(BibleFormatId);