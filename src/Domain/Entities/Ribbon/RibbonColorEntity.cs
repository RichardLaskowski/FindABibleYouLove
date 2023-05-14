using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonColorEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? RibbonColorID => Id;
    public string RibbonColor { get; set; } = string.Empty;
}
