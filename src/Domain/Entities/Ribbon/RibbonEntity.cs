using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonEntity<TType> : SimpleEntity<TType> where TType : class
{
    public TType? RibbonID => Id;
    RibbonSizeEntity<TType> RibbonSize { get; set; } = new RibbonSizeEntity<TType>();
}
