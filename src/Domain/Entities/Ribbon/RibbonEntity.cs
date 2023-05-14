using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? RibbonID => Id;
    public RibbonSizeEntity<TType> RibbonSize { get; set; } = new RibbonSizeEntity<TType>();
}
