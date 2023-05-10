using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverColorContract<TType>(
    TType   CoverColorID,
    string  ColorName) : SimpleAPIContract<TType>(CoverColorID) where TType : class;
