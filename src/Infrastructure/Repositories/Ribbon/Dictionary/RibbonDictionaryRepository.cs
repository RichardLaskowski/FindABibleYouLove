using Application.Repositories.Ribbon;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDictionaryRepository<TType> : DictionaryBaseRepository<TType, RibbonEntity>, IRibbonRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonEntity> RibbonDictionary => (Dictionary<TType, RibbonEntity>)Dictionary;

    public override RibbonEntity Add(RibbonEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonEntity> AddRange(IEnumerable<RibbonEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonEntity> Find(Func<RibbonEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonEntity>> FindAsync(Func<RibbonEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}
