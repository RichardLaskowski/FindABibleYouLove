using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonColorContract<TType>(
    TType RibbonColorID,
    string ColorName)
    : BaseContract<TType>(RibbonColorID) where TType : class;