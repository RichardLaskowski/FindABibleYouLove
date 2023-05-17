using Domain.Base.Classes.Entities;

namespace Domain.Entities.Ribbon;

public class RibbonColorEntity : StringBaseEntity
{
    public string RibbonColorId => StringId;

    public string ColorName { get; set; } 

    public RibbonColorEntity() : base()
    {
        ColorName = string.Empty;
    }

    public RibbonColorEntity(string ribbonColorId, string colorName) : base(ribbonColorId)
    {
        ColorName = colorName;
    }

}
