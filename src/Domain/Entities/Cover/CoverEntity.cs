using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? CoverID => Id;
    public CoverColorEntity<TType> Color        = new();
    public CoverMaterialEntity<TType> Material  = new();
    public CoverDesignEntity<TType> Design      = new();

    public CoverEntity(TType id, CoverColorEntity<TType> color, CoverMaterialEntity<TType> material, CoverDesignEntity<TType> design) : base(id)
    {
        Color = color;
        Material = material;
        Design = design;
    }

    public CoverEntity(TType id) : base(id)
    {
    }
}
