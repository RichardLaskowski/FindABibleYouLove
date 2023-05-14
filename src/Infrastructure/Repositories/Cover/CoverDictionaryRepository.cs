using Application.Repositories.Cover;

using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDictionaryRepository<TType> : DictionaryRepository<TType, CoverEntity<TType>>, ICoverRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverEntity<TType>> CoverDictionary => (Dictionary<TType, CoverEntity<TType>>)Dictionary;
}

