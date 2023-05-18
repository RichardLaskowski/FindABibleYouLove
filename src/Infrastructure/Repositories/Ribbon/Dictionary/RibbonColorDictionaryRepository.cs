using Application.Repositories.Ribbon;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonColorDictionaryRepository<TType> : DictionaryBaseRepository<TType, RibbonColorEntity>, IRibbonColorRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonColorEntity> RibbonColorDictionary => (Dictionary<TType, RibbonColorEntity>)Dictionary;

    public override RibbonColorEntity Add(RibbonColorEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonColorEntity> AddRange(IEnumerable<RibbonColorEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonColorEntity> Find(Func<RibbonColorEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonColorEntity>> FindAsync(Func<RibbonColorEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonColorEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonColorEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonColorEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonColorEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonColorEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonColorEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonColorEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonColorEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

