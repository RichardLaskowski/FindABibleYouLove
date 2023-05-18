using Application.Repositories.Cover;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDictionaryRepository<TType> : DictionaryBaseRepository<TType, CoverEntity>, ICoverRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverEntity> CoverDictionary => (Dictionary<TType, CoverEntity>)Dictionary;

    public override CoverEntity Add(CoverEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverEntity> AddRange(IEnumerable<CoverEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverEntity> Find(Func<CoverEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverEntity>> FindAsync(Func<CoverEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

