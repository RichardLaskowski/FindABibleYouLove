using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverMaterialContract<TType>(
    TType CoverMaterialID,
    string MaterialName)
    : BaseContract<TType>(CoverMaterialID) where TType : class;
