using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverColorEntity<TType> : SimpleEntity<TType> where TType : class
{
    public TType? CoverColorID => Id;
    public string ColorName { get; set; } = string.Empty;
}
