using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Bible;

public record BibleFeatureContract(
    string Id,
    string FeatureName) 
    : StringBaseContract(Id); 