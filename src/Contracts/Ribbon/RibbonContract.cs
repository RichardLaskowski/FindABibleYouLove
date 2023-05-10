using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonContract<TType>(
    TType   RibbonID,
    string  RibbonColor,
    string  RibbonSize) 
    : SimpleAPIContract<TType>(RibbonID) where TType : class;