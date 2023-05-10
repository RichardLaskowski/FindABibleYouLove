using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverEntity<TType> : SimpleEntity<TType> where TType : class
{
    public TType? CoverID => Id;
    public CoverColorEntity<TType> Color = new CoverColorEntity<TType>();
    public CoverMaterialEntity<TType> Material = new CoverMaterialEntity<TType>();
    public CoverDesignEntity<TType> Design = new CoverDesignEntity<TType>();
}
