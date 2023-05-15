using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverColorEntity<TType> : BaseEntity<TType> where TType : class
{
    public CoverColorEntity(TType id) : base(id)
    {
    }

    public CoverColorEntity(TType id, string colorName) : base(id)
    {
        ColorName = colorName;
    }

    public TType? CoverColorID => Id;
    public string ColorName { get; set; } = string.Empty;
}
