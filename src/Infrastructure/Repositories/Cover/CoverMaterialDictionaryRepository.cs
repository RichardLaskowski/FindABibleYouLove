using Application.Repositories.Cover;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverMaterialDictionaryRepository<TType> : DictionaryRepository<TType, CoverMaterialEntity<TType>>, ICoverMaterialRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverMaterialEntity<TType>> CoverMaterialDictionary => (Dictionary<TType, CoverMaterialEntity<TType>>)Dictionary;
}

