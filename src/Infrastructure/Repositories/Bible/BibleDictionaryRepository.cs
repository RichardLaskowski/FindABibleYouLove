using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleDictionaryRepository<TType> : DictionaryRepository<TType, BibleEntity<TType>> , IBibleRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleEntity<TType>> BibleDictionary => (Dictionary<TType, BibleEntity<TType>>)Dictionary;
}

