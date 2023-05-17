using Domain.Base.Classes.Entities;

namespace Domain.Entities.Bible;

public class BibleTranslationEntity : StringBaseEntity 
{

    public string BibleTranslationId => StringId;

    public string TranslationName           { get; set; }
    public string TranslationAbbreviation   { get; set; }
    
    public BibleTranslationEntity() : base() 
    {
        TranslationName         = string.Empty;
        TranslationAbbreviation = string.Empty;
    }

    public BibleTranslationEntity(
        string bibleTranslationId,
        string translationName,
        string translationAbbreviation) : base(bibleTranslationId)
    {
        TranslationName         = translationName;
        TranslationAbbreviation = translationAbbreviation;
    }
}
