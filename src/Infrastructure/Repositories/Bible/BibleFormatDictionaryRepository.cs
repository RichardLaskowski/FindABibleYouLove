using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatDictionaryRepository<TType> : DictionaryRepository<TType, BibleFormatEntity<TType>>, IBibleFormatRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleFormatEntity<TType>> BibleFormatDictionary => (Dictionary<TType, BibleFormatEntity<TType>>)Dictionary;
}

