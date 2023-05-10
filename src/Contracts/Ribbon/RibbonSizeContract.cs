using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonSizeContract<TType>(
    TType   RibbonSizeID,
    string  SizeValue) 
    : SimpleAPIContract<TType>(RibbonSizeID) where TType : class;