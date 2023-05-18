using Application.Repositories.Ribbon;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonSizeDictionaryRepository<TType> : DictionaryBaseRepository<TType, RibbonSizeEntity>, IRibbonSizeRepository<TType> where TType : class
{
    protected Dictionary<TType, RibbonSizeEntity> RibbonSizeDictionary => (Dictionary<TType, RibbonSizeEntity>)Dictionary;

    public override RibbonSizeEntity Add(RibbonSizeEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonSizeEntity> AddRange(IEnumerable<RibbonSizeEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonSizeEntity> Find(Func<RibbonSizeEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonSizeEntity>> FindAsync(Func<RibbonSizeEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override RibbonSizeEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<RibbonSizeEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<RibbonSizeEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<RibbonSizeEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(RibbonSizeEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<RibbonSizeEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(RibbonSizeEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<RibbonSizeEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}
