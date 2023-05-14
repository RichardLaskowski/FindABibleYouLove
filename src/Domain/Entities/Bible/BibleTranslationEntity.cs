using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleTranslationEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? BibleTranslationID => Id;
    public string TranslationName { get; set; } = string.Empty;
    public string TranslationAbbreviation { get; set; } = string.Empty;
    public string TranslationDescription { get; set; } = string.Empty;
}
