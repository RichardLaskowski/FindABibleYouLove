using System.Collections.ObjectModel;

using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonDetailEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? RibbonDetailID => Id;
    public IEnumerable<RibbonEntity<TType>> Ribbons = new Collection<RibbonEntity<TType>>();

    public RibbonDetailEntity(TType id, IEnumerable<RibbonEntity<TType>> ribbons) : base(id)
    {
        Ribbons = ribbons;
    }

    public RibbonDetailEntity(TType id) : base(id)
    {
    }
}
