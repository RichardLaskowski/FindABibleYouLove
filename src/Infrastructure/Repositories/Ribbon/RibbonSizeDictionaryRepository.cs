using Application.Repositories.Ribbon;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonSizeDictionaryRepository<TType> : DictionaryRepository<TType, RibbonSizeEntity<TType>>, IRibbonSizeRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonSizeEntity<TType>> RibbonSizeDictionary => (Dictionary<TType, RibbonSizeEntity<TType>>)Dictionary;
}
