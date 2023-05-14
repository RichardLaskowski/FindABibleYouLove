using Application.Repositories.Cover;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverColorDictionaryRepository<TType> : DictionaryRepository<TType, CoverColorEntity<TType>>, ICoverColorRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverColorEntity<TType>> CoverColorDictionary => (Dictionary<TType, CoverColorEntity<TType>>)Dictionary;
}

