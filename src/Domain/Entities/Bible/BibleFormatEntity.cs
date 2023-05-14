using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleFormatEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? BibleFormatID => Id;
    public string FormatName { get; set; } = string.Empty;
    public string FormatDescription { get; set; } = string.Empty;
}
