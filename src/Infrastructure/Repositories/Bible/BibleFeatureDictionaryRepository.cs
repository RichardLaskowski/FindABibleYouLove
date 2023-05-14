using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureDictionaryRepository<TType> : DictionaryRepository<TType, BibleFeatureEntity<TType>>, IBibleFeatureRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleFeatureEntity<TType>> BibleFeatureDictionary => (Dictionary<TType, BibleFeatureEntity<TType>>)Dictionary;
}

