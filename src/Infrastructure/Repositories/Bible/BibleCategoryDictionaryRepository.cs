using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryDictionaryRepository<TType> : DictionaryRepository<TType, BibleCategoryEntity<TType>>, IBibleCategoryRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleCategoryEntity<TType>> BibleCategoryDictionary => (Dictionary<TType, BibleCategoryEntity<TType>>)Dictionary;
}


