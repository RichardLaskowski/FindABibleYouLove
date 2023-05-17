using Application.Repositories.Ribbon;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonColorDictionaryRepository<TType> : DictionaryBaseRepository<TType, RibbonColorEntity<TType>>, IRibbonColorRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonColorEntity<TType>> RibbonColorDictionary => (Dictionary<TType, RibbonColorEntity<TType>>)Dictionary;

    public override RibbonColorEntity<TType> Add(RibbonColorEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonColorEntity<TType>> AddRange(IEnumerable<RibbonColorEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonColorEntity<TType>> Find(Func<RibbonColorEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonColorEntity<TType>>> FindAsync(Func<RibbonColorEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonColorEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonColorEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonColorEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonColorEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonColorEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonColorEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonColorEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonColorEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

