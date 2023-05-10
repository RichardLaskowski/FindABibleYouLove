using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverMaterialContract<TType>(
    TType   CoverMaterialID,
    string  MaterialName) : SimpleAPIContract<TType>(CoverMaterialID) where TType : class;
