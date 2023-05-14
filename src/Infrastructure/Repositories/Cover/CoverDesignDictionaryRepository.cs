using Application.Repositories.Cover;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDesignDictionaryRepository<TType> : DictionaryRepository<TType, CoverDesignEntity<TType>>, ICoverDesignRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverDesignEntity<TType>> CoverDesignDictionary => (Dictionary<TType, CoverDesignEntity<TType>>)Dictionary;
}

