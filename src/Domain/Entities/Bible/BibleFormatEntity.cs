using Domain.Base.Classes.Entities;

namespace Domain.Entities.Bible;

public class BibleFormatEntity: StringBaseEntity
{
    public string BibleFormatId => StringId;

    public string FormatName        { get; set; } 

    public BibleFormatEntity() : base() 
    {
        FormatName          = string.Empty;
    }

    public BibleFormatEntity(string bibleFormatId, string formatName) : base(bibleFormatId) { FormatName = formatName; }
}
