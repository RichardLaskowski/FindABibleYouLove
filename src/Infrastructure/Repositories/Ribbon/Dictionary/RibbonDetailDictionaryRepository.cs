using Application.Repositories.Ribbon;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDetailDictionaryRepository<TType> : DictionaryRepository<TType, RibbonDetailEntity<TType>>, IRibbonDetailRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonDetailEntity<TType>> RibbonDetailDictionary => (Dictionary<TType, RibbonDetailEntity<TType>>)Dictionary;

    public override RibbonDetailEntity<TType> Add(RibbonDetailEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonDetailEntity<TType>> AddRange(IEnumerable<RibbonDetailEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonDetailEntity<TType>> Find(Func<RibbonDetailEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonDetailEntity<TType>>> FindAsync(Func<RibbonDetailEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonDetailEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonDetailEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonDetailEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonDetailEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonDetailEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonDetailEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonDetailEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonDetailEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

