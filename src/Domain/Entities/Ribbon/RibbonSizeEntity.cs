using Domain.Base.Classes.Entities;

namespace Domain.Entities.Ribbon;

public class RibbonSizeEntity : StringBaseEntity
{
    public string RibbonSizeId => StringId;

    public decimal RibbonSize { get; set; }

    public RibbonSizeEntity() : base() 
    {
    
    }

    public RibbonSizeEntity(string ribbonSizeId, decimal ribbonSize) : base(ribbonSizeId)
    {
        RibbonSize = ribbonSize;
    }
}
