using Domain.Base.Classes.Entities;

namespace Domain.Entities.Cover;

public class CoverEntity : StringBaseEntity
{
    public string CoverId => StringId;

    public CoverColorEntity Color       { get; set; }  
    public CoverMaterialEntity Material { get; set; }
    public CoverDesignEntity Design     { get; set; }

    public CoverEntity() : base()
    {
        Color = new CoverColorEntity();
        Material = new CoverMaterialEntity();
        Design = new CoverDesignEntity();
    }

    public CoverEntity(
        string id,
        CoverColorEntity color,
        CoverMaterialEntity material,
        CoverDesignEntity design) : base(id)
    {
        Color       = color;
        Material    = material;
        Design      = design;
    }
}
