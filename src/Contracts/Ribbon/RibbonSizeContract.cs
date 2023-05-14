using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonSizeContract<TType>(
    TType RibbonSizeID,
    string SizeValue)
    : BaseContract<TType>(RibbonSizeID) where TType : class;