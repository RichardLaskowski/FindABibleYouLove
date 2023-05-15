using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonEntity<TType> : BaseEntity<TType> where TType : class
{
    public RibbonEntity(TType id) : base(id)
    {
    }

    public RibbonEntity(TType id, RibbonSizeEntity<TType> ribbonSize) : base(id)
    {
        RibbonSize = ribbonSize;
    }

    public TType? RibbonID => Id;
    public RibbonSizeEntity<TType> RibbonSize { get; set; } = new RibbonSizeEntity<TType>();
}
