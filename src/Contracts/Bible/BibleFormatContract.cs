using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleFormatContract<TType>(
    TType BibleFormatID,
    string FormatName,
    string FormatDescription)
    : BaseContract<TType>(ID: BibleFormatID) where TType : class;