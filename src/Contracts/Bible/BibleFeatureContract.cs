using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleFeatureContract<TType>(
    TType BibleFeatureID,
    string FeatureName,
    string FeatureDescription) 
    : BaseContract<TType>(ID: BibleFeatureID) where TType : class;