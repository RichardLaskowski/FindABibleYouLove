using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleFormatEntity<TType> : BaseEntity<TType> 
    where TType : class
{
    public TType? BibleFormatID => Id;
    public string FormatName { get; set; } 
    public string FormatDescription { get; set; } 

    public BibleFormatEntity() : base() 
    {
        FormatName = string.Empty;
        FormatDescription = string.Empty;
    }
    public BibleFormatEntity(
        TType bibleFormatID,
        string formatName,
        string formatDescription) : base(bibleFormatID)
    {
        FormatName = formatName;
        FormatDescription = formatDescription;
    }
}
