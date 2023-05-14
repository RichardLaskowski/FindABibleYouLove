using Application.Repositories.Ribbon;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDetailDictionaryRepository<TType> : DictionaryRepository<TType, RibbonDetailEntity<TType>>, IRibbonDetailRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonDetailEntity<TType>> RibbonDetailDictionary => (Dictionary<TType, RibbonDetailEntity<TType>>)Dictionary;
}

