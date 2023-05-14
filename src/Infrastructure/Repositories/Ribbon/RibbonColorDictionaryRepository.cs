using Application.Repositories.Ribbon;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonColorDictionaryRepository<TType> : DictionaryRepository<TType, RibbonColorEntity<TType>>, IRibbonColorRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonColorEntity<TType>> RibbonColorDictionary => (Dictionary<TType, RibbonColorEntity<TType>>)Dictionary;
}

