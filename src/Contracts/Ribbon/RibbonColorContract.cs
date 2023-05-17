using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonColorContract(
    string RibbonColorId,
    string ColorName)
    : StringBaseContract(RibbonColorId);