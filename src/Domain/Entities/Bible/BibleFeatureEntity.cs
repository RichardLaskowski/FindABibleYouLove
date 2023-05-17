using Domain.Base.Classes.Entities;

namespace Domain.Entities.Bible;

public class BibleFeatureEntity : StringBaseEntity
{
    public string BibleFeatureId => StringId;

    public string FeatureName           { get; set; }

    public BibleFeatureEntity() : base() 
    { 
        FeatureName         = string.Empty;
    }

    public BibleFeatureEntity(
        string bibleFeatureId,
        string featureName) : base(bibleFeatureId)
    {
        FeatureName         = featureName;
    }
}
