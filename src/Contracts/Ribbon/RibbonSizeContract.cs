using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonSizeContract(
    string RibbonSizeId,
    string SizeValue)
    : StringBaseContract(RibbonSizeId);