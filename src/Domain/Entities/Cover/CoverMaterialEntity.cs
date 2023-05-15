using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverMaterialEntity<TType> : BaseEntity<TType> 
    where TType : class
{
    public TType? CoverMaterialID => Id;
    public string MaterialName { get; set; } = string.Empty;
    public string MaterialDescription { get; set; } = string.Empty;
    
    public CoverMaterialEntity() : base()
    {
    }

    public CoverMaterialEntity(TType id, string materialName, string materialDescription) : base(id)
    {
        MaterialName = materialName;
        MaterialDescription = materialDescription;
    }

}
