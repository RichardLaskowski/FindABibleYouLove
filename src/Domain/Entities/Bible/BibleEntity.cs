using System.Collections.ObjectModel;

using Domain.Common.Classes;
using Domain.Entities.Cover;
using Domain.Entities.Ribbon;

namespace Domain.Entities.Bible;

public class BibleEntity<TType> : BaseEntity<TType> 
    where TType : class
{
    public TType? BibleID => Id;
    public BibleFormatEntity<TType> Format { get; set; } 
    public BibleTranslationEntity<TType> Translation { get; set; } 
    public CoverEntity<TType> Cover { get; set; } 
    public RibbonDetailEntity<TType> RibbonDetail { get; set; } 
    public IEnumerable<BibleFeatureEntity<TType>> Features { get; set; } 
    public IEnumerable<BibleCategoryEntity<TType>> Categories { get; set; } 

    public BibleEntity() : base() 
    {
        Format          = new BibleFormatEntity<TType>();
        Translation     = new BibleTranslationEntity<TType>();
        Cover           = new CoverEntity<TType>();
        RibbonDetail    = new RibbonDetailEntity<TType>();
        Features        = new Collection<BibleFeatureEntity<TType>>();
        Categories      = new Collection<BibleCategoryEntity<TType>>();
    }

    public BibleEntity(
        TType bibleID,
        BibleFormatEntity<TType> format,
        BibleTranslationEntity<TType> translation,
        CoverEntity<TType> cover,
        RibbonDetailEntity<TType> ribbonDetail,
        IEnumerable<BibleFeatureEntity<TType>> features,
        IEnumerable<BibleCategoryEntity<TType>> categories) : base(bibleID)
    {
        Format = format;
        Translation = translation;
        Cover = cover;
        RibbonDetail = ribbonDetail;
        Features = features;
        Categories = categories;
    }
}
