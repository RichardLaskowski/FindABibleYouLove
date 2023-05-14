using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverMaterialEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? CoverMaterialID => Id;
    public string Materialname { get; set; } = string.Empty;
    public string MaterialDescription { get; set; } = string.Empty;
}
