using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverContract(
    string CoverId,
    string CoverMaterial,
    string CoverColor,
    string CoverDesign)
    : StringBaseContract(CoverId);

