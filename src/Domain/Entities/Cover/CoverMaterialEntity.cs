using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverMaterialEntity<TType> : BaseEntity<TType> where TType : class
{
    public CoverMaterialEntity(TType id) : base(id)
    {
    }

    public CoverMaterialEntity(TType id, string materialname, string materialDescription) : base(id)
    {
        Materialname = materialname;
        MaterialDescription = materialDescription;
    }

    public TType? CoverMaterialID => Id;
    public string Materialname { get; set; } = string.Empty;
    public string MaterialDescription { get; set; } = string.Empty;
}
