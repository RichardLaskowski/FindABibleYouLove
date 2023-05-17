using System.Collections.ObjectModel;
using Domain.Base.Classes.Entities;

namespace Domain.Entities.Ribbon;

public class RibbonDetailEntity: StringBaseEntity
{
    public string RibbonDetailId => StringId;


    public IEnumerable<RibbonEntity> Ribbons {get; set; }

    public RibbonDetailEntity() : base()
    {
        Ribbons = new Collection<RibbonEntity>();
    }
    
    public RibbonDetailEntity(string ribbonDetailId, IEnumerable<RibbonEntity> ribbons) : base(ribbonDetailId)
    {
        Ribbons = ribbons;
    }

}
