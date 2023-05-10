using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonColorContract<TType>(
    TType   RibbonColorID,
    string  ColorName) 
    : SimpleAPIContract<TType>(RibbonColorID) where TType : class;