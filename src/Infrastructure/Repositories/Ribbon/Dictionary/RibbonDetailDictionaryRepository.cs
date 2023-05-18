using Application.Repositories.Ribbon;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDetailDictionaryRepository<TType> : DictionaryBaseRepository<TType, RibbonDetailEntity>, IRibbonDetailRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonDetailEntity> RibbonDetailDictionary => (Dictionary<TType, RibbonDetailEntity>)Dictionary;

    public override RibbonDetailEntity Add(RibbonDetailEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonDetailEntity> AddRange(IEnumerable<RibbonDetailEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonDetailEntity> Find(Func<RibbonDetailEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonDetailEntity>> FindAsync(Func<RibbonDetailEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonDetailEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonDetailEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonDetailEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonDetailEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonDetailEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonDetailEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonDetailEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonDetailEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

