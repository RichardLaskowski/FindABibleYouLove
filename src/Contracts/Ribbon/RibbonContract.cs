using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonContract(
    string RibbonId,
    string RibbonColor,
    string RibbonSize)
    : StringBaseContract(RibbonId);