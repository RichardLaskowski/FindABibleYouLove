using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverContract<TType>(
    TType   CoverID,
    string  CoverMaterial,
    string  CoverColor,
    string  CoverDesign) : SimpleAPIContract<TType>(CoverID) where TType : class;

