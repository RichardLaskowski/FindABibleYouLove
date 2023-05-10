using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleFeatureEntity<TType> : SimpleEntity<TType> where TType : class
{
    public TType? BibleFeatureID => Id;
    public string FeatureName { get; set; } = string.Empty;
    public string FeatureDescription { get; set; } = string.Empty;
}
