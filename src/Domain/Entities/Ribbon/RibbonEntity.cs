using Domain.Base.Classes.Entities;

namespace Domain.Entities.Ribbon;

public class RibbonEntity : StringBaseEntity
{
    public string RibbonId => StringId;

    public RibbonSizeEntity RibbonSize { get; set; } 

    public RibbonEntity() : base()
    {
        RibbonSize = new RibbonSizeEntity();
    }
    public RibbonEntity(string ribbonSizeId, RibbonSizeEntity ribbonSize) : base(ribbonSizeId)
    {
        RibbonSize = ribbonSize;
    }

}
