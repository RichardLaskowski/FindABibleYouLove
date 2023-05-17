using Domain.Base.Classes.Entities;

namespace Domain.Entities.Cover;

public class CoverColorEntity: StringBaseEntity
{
    public string? CoverColorId => StringId;

    public string ColorName { get; set; }

    public CoverColorEntity() : base()
    {
        ColorName = string.Empty;
    }

    public CoverColorEntity(string coverColorId, string colorName) : base(coverColorId)
    {
        ColorName = colorName;
    }
}
