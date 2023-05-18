using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleFeatureContract(
    string BibleFeatureId,
    string FeatureName) 
    : StringBaseContract(BibleFeatureId); 