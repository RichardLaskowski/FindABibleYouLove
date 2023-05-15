using Application.Repositories.Ribbon;

using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDictionaryRepository<TType> : DictionaryRepository<TType, RibbonEntity<TType>>, IRibbonRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonEntity<TType>> RibbonDictionary => (Dictionary<TType, RibbonEntity<TType>>)Dictionary;

    public override RibbonEntity<TType> Add(RibbonEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonEntity<TType>> AddRange(IEnumerable<RibbonEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonEntity<TType>> Find(Func<RibbonEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonEntity<TType>>> FindAsync(Func<RibbonEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}
