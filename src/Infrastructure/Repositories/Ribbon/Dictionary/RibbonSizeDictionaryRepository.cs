using Application.Repositories.Ribbon;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonSizeDictionaryRepository<TType> : DictionaryRepository<TType, RibbonSizeEntity<TType>>, IRibbonSizeRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonSizeEntity<TType>> RibbonSizeDictionary => (Dictionary<TType, RibbonSizeEntity<TType>>)Dictionary;

    public override RibbonSizeEntity<TType> Add(RibbonSizeEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonSizeEntity<TType>> AddRange(IEnumerable<RibbonSizeEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonSizeEntity<TType>> Find(Func<RibbonSizeEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonSizeEntity<TType>>> FindAsync(Func<RibbonSizeEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonSizeEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonSizeEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonSizeEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonSizeEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonSizeEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonSizeEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonSizeEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonSizeEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}
