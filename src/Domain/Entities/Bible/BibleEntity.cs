using System.Collections.ObjectModel;
using Domain.Base.Classes.Entities;
using Domain.Entities.Cover;
using Domain.Entities.Ribbon;

namespace Domain.Entities.Bible;

public class BibleEntity : StringBaseEntity
{
    public string? BibleId => StringId;

    public BibleFormatEntity Format                     { get; set; } 
    public BibleTranslationEntity Translation           { get; set; } 
    public CoverEntity Cover                            { get; set; } 
    public RibbonDetailEntity RibbonDetail              { get; set; } 
    public IEnumerable<BibleFeatureEntity> Features     { get; set; } 
    public IEnumerable<BibleCategoryEntity> Categories  { get; set; } 

    public BibleEntity() : base() 
    {
        Format          = new BibleFormatEntity();
        Translation     = new BibleTranslationEntity();
        Cover           = new CoverEntity();
        RibbonDetail    = new RibbonDetailEntity();
        Features        = new Collection<BibleFeatureEntity>();
        Categories      = new Collection<BibleCategoryEntity>();
    }

    public BibleEntity(
        string bibleId,
        BibleFormatEntity format,
        BibleTranslationEntity translation,
        CoverEntity cover,
        RibbonDetailEntity ribbonDetail,
        IEnumerable<BibleFeatureEntity> features,
        IEnumerable<BibleCategoryEntity> categories) : base(bibleId)
    {
        Format          = format;
        Translation     = translation;
        Cover           = cover;
        RibbonDetail    = ribbonDetail;
        Features        = features;
        Categories      = categories;
    }
}
