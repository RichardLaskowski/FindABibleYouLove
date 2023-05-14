using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleTranslationDictionaryRepository<TType> : DictionaryRepository<TType, BibleTranslationEntity<TType>>, IBibleTranslationRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleTranslationEntity<TType>> BibleTranslationDictionary => (Dictionary<TType, BibleTranslationEntity<TType>>)Dictionary;
}

