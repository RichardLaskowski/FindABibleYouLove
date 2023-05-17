using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverMaterialContract(
    string CoverMaterialId,
    string MaterialName)
    : StringBaseContract(CoverMaterialId);
