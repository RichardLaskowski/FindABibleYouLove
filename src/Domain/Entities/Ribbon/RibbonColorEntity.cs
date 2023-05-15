using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonColorEntity<TType> : BaseEntity<TType> where TType : class
{
    public RibbonColorEntity(TType id) : base(id)
    {
    }

    public RibbonColorEntity(TType id, string ribbonColor) : base(id)
    {
        RibbonColor = ribbonColor;
    }

    public TType? RibbonColorID => Id;
    public string RibbonColor { get; set; } = string.Empty;
}
