using Application.Repositories.Ribbon;

using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDictionaryRepository<TType> : DictionaryRepository<TType, RibbonEntity<TType>>, IRibbonRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonEntity<TType>> RibbonDictionary => (Dictionary<TType, RibbonEntity<TType>>)Dictionary;
}
