using Domain.Base.Classes.Entities;

namespace Domain.Entities.Cover;

public class CoverMaterialEntity : StringBaseEntity
{
    public string CoverMaterialId => StringId;

    public string MaterialName { get; set; }

    public CoverMaterialEntity() : base()
    {
        MaterialName = string.Empty;
    }

    public CoverMaterialEntity(string coverMaterialId, string materialName) : base(coverMaterialId)
    {
        MaterialName = materialName;
    }
}
