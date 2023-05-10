using System.Collections.ObjectModel;

using Domain.Common.Classes;
using Domain.Entities.Cover;
using Domain.Entities.Ribbon;

namespace Domain.Entities.Bible;

public class BibleEntity<TType> : SimpleEntity<TType> where TType : class
{
    public TType? BibleID => Id;
    public BibleFormatEntity<TType> Format { get; set; } = new BibleFormatEntity<TType>();
    public BibleTranslationEntity<TType> Translation { get; set; } = new BibleTranslationEntity<TType>();
    public CoverEntity<TType> Cover { get; set; } = new CoverEntity<TType>();
    public RibbonDetailEntity<TType> RibbonDetail { get; set; } = new RibbonDetailEntity<TType>();
    public IEnumerable<BibleFeatureEntity<TType>> Features { get; set; } = new Collection<BibleFeatureEntity<TType>>();
    public IEnumerable<BibleCategoryEntity<TType>> Categories { get; set; } = new Collection<BibleCategoryEntity<TType>>();
}
