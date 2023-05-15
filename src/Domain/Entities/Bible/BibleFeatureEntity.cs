using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleFeatureEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? BibleFeatureID => Id;
    public string FeatureName { get; set; }
    public string FeatureDescription { get; set; }

    public BibleFeatureEntity() : base() 
    { 
        FeatureName         = string.Empty;
        FeatureDescription  = string.Empty;
    }

    public BibleFeatureEntity(
        TType bibleFeatureID,
        string featureName,
        string featureDescription) : base(bibleFeatureID)
    {
        FeatureName = featureName;
        FeatureDescription = featureDescription;
    }
}
