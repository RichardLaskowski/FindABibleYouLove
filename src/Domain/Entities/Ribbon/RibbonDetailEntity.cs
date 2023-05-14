using System.Collections.ObjectModel;

using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonDetailEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? RibbonDetailID => Id;
    public IEnumerable<RibbonEntity<TType>> Ribbons = new Collection<RibbonEntity<TType>>();
}
